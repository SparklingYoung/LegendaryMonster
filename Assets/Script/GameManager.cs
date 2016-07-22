using System;
using System.Collections;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public float radius;
    public int delay;

	//zhangjingjing
	private GameObject success;
	private GameObject gameOver;
	private GameObject gameOverWait;
	private GameObject pause;
    private bool fail = false;

    public GameObject player;
    public GameObject countDown;
    public int Score { get; private set; }

    IEnumerator WaitToStart() {
        while (countDown.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsTag("count")) {
            yield return null;
        }
		countDown.GetComponent<Animator> ().updateMode = AnimatorUpdateMode.Normal;
        Destroy(countDown);
        Time.timeScale = 1;
		pause.GetComponent<BoxCollider> ().enabled = true;
    }


    // Use this for initialization
    void Start () {
		Debug.Log ("Hello");
	    Time.timeScale = 0;
        PlayerPrefs.SetInt("Time", -1);
        PlayerPrefs.Save();
	    StartCoroutine(WaitToStart());

		//zhangjingjing
		success = GameObject.FindWithTag ("success");
		gameOver = GameObject.FindWithTag ("gameOver");
		gameOverWait = GameObject.FindWithTag ("gameOverWait");
		//NGUITools.SetActive (success,false);
		NGUITools.SetActive (gameOver,false);
		PlayerPrefs.SetInt ("successMark",0);
		pause = GameObject.Find ("PauseUnit");
		pause.GetComponent<BoxCollider> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if ((player.transform.position - Vector3.zero).magnitude > radius) {
            Debug.Log("radius");
            Success();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	    }
	}

    public void AddScore() {
        Score++;
    }

    public void Success() {
        Debug.Log("Finish");
        PlayerPrefs.Save();

		//zhangjingjing
		Time.timeScale = 0;
		if(PlayerPrefs.GetInt("successMark") == 0){
			NGUITools.SetActive (success,true);
		}
		
		if((Application.loadedLevel < 11)&&(Application.loadedLevel > PlayerPrefs.GetInt("level"))){
			GameObject.FindWithTag("global").GetComponent<global>().add();
		}
		
		GameObject.FindWithTag("c1Anim").GetComponent<collectionAnimation>().updateCollectionLog();

    }

    public void Failed() {
        if (!fail) {
            fail = true;
            Debug.Log("Failed");
            GameObject.Find("InputManager").SendMessage("Stop");
            player.GetComponent<Animator>().SetTrigger("Death");
            Time.timeScale = 0;

            //zhangjingjing
            int health = PlayerPrefs.GetInt("health");
            if (health > 1) {
                int level;
                level = PlayerPrefs.GetInt("level");
                NGUITools.SetActive(gameOver, true);
                GameObject levelAbove;
                GameObject levelBelow;
                levelAbove = GameObject.Find("levelAbove");
                levelBelow = GameObject.Find("levelBelow");
                Debug.Log(level);
                if (Application.loadedLevel < level) {
                    NGUITools.SetActive(levelBelow, false);
                }
                else {
                    NGUITools.SetActive(levelAbove, false);
                }
            }
            else {
                NGUITools.SetActive(gameOverWait, true);
            }
            health--;
            PlayerPrefs.SetInt("health", health);
        }
    }

	public void StartCountDown() {
		countDown.GetComponent<Animator> ().enabled = true;
	}
}
