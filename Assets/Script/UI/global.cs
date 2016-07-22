using UnityEngine;
using System.Collections;

public class global : MonoBehaviour {
	static int level;
	private static int sec;
	private static int min;
	private static GameObject healthTime;
	private static int timeMark;

	void Awake(){
		DontDestroyOnLoad (this.gameObject);
	}

	void Start(){
		if(!PlayerPrefs.HasKey("level")){
			PlayerPrefs.SetInt("level",1);//update
		}
	}

	void Update(){
		if(Application.loadedLevel == 1){
			level = PlayerPrefs.GetInt ("level");
			switch(level){
			case 10:
				Destroy(GameObject.FindWithTag("lock1"));
				Destroy(GameObject.FindWithTag("lock2"));
				Destroy(GameObject.FindWithTag("lock3"));
				Destroy(GameObject.FindWithTag("lock4"));
				Destroy(GameObject.FindWithTag("lock5"));
				Destroy(GameObject.FindWithTag("lock6"));
				Destroy(GameObject.FindWithTag("lock7"));
				Destroy(GameObject.FindWithTag("lock8"));
				Destroy(GameObject.FindWithTag("lock9"));
				Destroy(GameObject.FindWithTag("lock10"));
				break;
			case 9:
				Destroy(GameObject.FindWithTag("lock1"));
				Destroy(GameObject.FindWithTag("lock2"));
				Destroy(GameObject.FindWithTag("lock3"));
				Destroy(GameObject.FindWithTag("lock4"));
				Destroy(GameObject.FindWithTag("lock5"));
				Destroy(GameObject.FindWithTag("lock6"));
				Destroy(GameObject.FindWithTag("lock7"));
				Destroy(GameObject.FindWithTag("lock8"));
				Destroy(GameObject.FindWithTag("lock9"));
				break;
			case 8:
				Destroy(GameObject.FindWithTag("lock1"));
				Destroy(GameObject.FindWithTag("lock2"));
				Destroy(GameObject.FindWithTag("lock3"));
				Destroy(GameObject.FindWithTag("lock4"));
				Destroy(GameObject.FindWithTag("lock5"));
				Destroy(GameObject.FindWithTag("lock6"));
				Destroy(GameObject.FindWithTag("lock7"));
				Destroy(GameObject.FindWithTag("lock8"));
				break;
			case 7:
				Destroy(GameObject.FindWithTag("lock1"));
				Destroy(GameObject.FindWithTag("lock2"));
				Destroy(GameObject.FindWithTag("lock3"));
				Destroy(GameObject.FindWithTag("lock4"));
				Destroy(GameObject.FindWithTag("lock5"));
				Destroy(GameObject.FindWithTag("lock6"));
				Destroy(GameObject.FindWithTag("lock7"));
				break;
			case 6:
				Destroy(GameObject.FindWithTag("lock1"));
				Destroy(GameObject.FindWithTag("lock2"));
				Destroy(GameObject.FindWithTag("lock3"));
				Destroy(GameObject.FindWithTag("lock4"));
				Destroy(GameObject.FindWithTag("lock5"));
				Destroy(GameObject.FindWithTag("lock6"));
				break;
			case 5:
				Destroy(GameObject.FindWithTag("lock1"));
				Destroy(GameObject.FindWithTag("lock2"));
				Destroy(GameObject.FindWithTag("lock3"));
				Destroy(GameObject.FindWithTag("lock4"));
				Destroy(GameObject.FindWithTag("lock5"));
				break;
			case 4:
				Destroy(GameObject.FindWithTag("lock1"));
				Destroy(GameObject.FindWithTag("lock2"));
				Destroy(GameObject.FindWithTag("lock3"));
				Destroy(GameObject.FindWithTag("lock4"));
				break;
			case 3:
				Destroy(GameObject.FindWithTag("lock1"));
				Destroy(GameObject.FindWithTag("lock2"));
				Destroy(GameObject.FindWithTag("lock3"));
				break;
			case 2:
				Destroy(GameObject.FindWithTag("lock1"));
				Destroy(GameObject.FindWithTag("lock2"));
				break;
			case 1:
				Destroy(GameObject.FindWithTag("lock1"));
				break;
			}
		}


		if ((Application.loadedLevel == 1)&&(healthTime == null)) {
			healthTime = GameObject.Find("healthTime");
		}

		int health;
		if(!PlayerPrefs.HasKey("health")){
			PlayerPrefs.SetInt("health",5);
		}
		health = PlayerPrefs.GetInt ("health");

		if(health < 5){
			if(!PlayerPrefs.HasKey("isTiming")){
				PlayerPrefs.SetInt("isTiming",1);
			}

			int isTiming = PlayerPrefs.GetInt("isTiming");

			if(isTiming != 0){
				PlayerPrefs.SetInt("isTiming",0);
				timeMark = Mathf.FloorToInt(Time.realtimeSinceStartup);
			}
		
			timing();
		}

	}

	void timing(){
		int timeTemp = Mathf.FloorToInt(Time.realtimeSinceStartup) - timeMark;
		timeTemp = 600 - timeTemp;
		min = timeTemp / 60;
		sec = timeTemp % 60;
		if (min > 0 || sec >= 0) {
			if(Application.loadedLevel == 1){
				if(min > 9){
					if(sec > 9){
						healthTime.GetComponent<UILabel>().text = min + ":" + sec;
					}else{
						healthTime.GetComponent<UILabel>().text = min + ":0" + sec;
					}
				}else{
					if(sec > 9){
						healthTime.GetComponent<UILabel>().text = "0" + min + ":" + sec;
					}else{
						healthTime.GetComponent<UILabel>().text = "0" + min + ":0" + sec;
					}
				}
			}
		} else {
			int health;
			health = PlayerPrefs.GetInt("health");
			health ++;
			PlayerPrefs.SetInt("health",health);
			PlayerPrefs.SetInt("isTiming",1);
		}
	}

	public void add(){
		level ++;
		PlayerPrefs.SetInt ("level",level);
		//Debug.Log (level);
	}
}
