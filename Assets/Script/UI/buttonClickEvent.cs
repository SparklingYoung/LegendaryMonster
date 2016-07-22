using UnityEngine;
using System.Collections;

public class buttonClickEvent : MonoBehaviour {
	private GameObject des;
	private GameObject start;
	private GameObject restart;
	private GameObject success;
	private GameObject time;
	private int timeType;
	private int min;
	private int sec;
	private int msec;
	private GameObject gameOverWait;
	private int totalTime;
	//private int current;
	
	void Start(){
		if((Application.loadedLevel > 1)&&(Application.loadedLevel < 12)){
			int restartFlag;
			restartFlag = PlayerPrefs.GetInt ("restart");
			des = GameObject.FindWithTag ("des");
			start = GameObject.FindWithTag ("start");
			restart = GameObject.FindWithTag ("restart");
			success = GameObject.FindWithTag ("success");
			gameOverWait = GameObject.Find("gameOverWait");
			NGUITools.SetActive (gameOverWait,false);
			NGUITools.SetActive (success,false);

			if(restartFlag == 1){
				GameObject.FindGameObjectWithTag ("GameController").SendMessage ("StartCountDown");
				NGUITools.SetActive (des,false);
			}else{
				Time.timeScale = 0;
				NGUITools.SetActive (restart,false);
			}

			timeType = PlayerPrefs.GetInt("Time");
			time = GameObject.FindWithTag("time");
			if(timeType < 0){
				totalTime = 0;
			}else{
				totalTime = timeType*60;
			}
			InvokeRepeating("timing",0.1f,0.1f);
			//PlayerPrefs.SetInt("Time",-5);
//			timeType = PlayerPrefs.GetInt("Time");
//			if(timeType < 0){
//				min = 0;
//				sec = 0;
//				msec = 0;
//			}else{
//				sec = timeType;
//				msec = 0;
//			}
//			time = GameObject.FindWithTag("time");
//			InvokeRepeating("timing",1,0.1f);
		}
	}


	void timing(){
		if ((Application.loadedLevel > 1) && (Application.loadedLevel < 12)) {
			if(timeType < 0){
				totalTime += 6; 
			}else{
				if(totalTime > 0){
					totalTime -= 6;
				}else{
					totalTime = 0;
				}
			}

			min = totalTime/3600;
			sec = totalTime/60;
			msec = totalTime%60;

			if(min > 9){
				if(sec > 9){
					if(msec > 9){
						time.GetComponent<UILabel>().text = min + ":" + sec + ":" + msec;
					}else{
						time.GetComponent<UILabel>().text = min + ":" + sec + ":0" + msec;
					}
				}else{
					if(msec > 9){
						time.GetComponent<UILabel>().text = min + ":0" + sec + ":" + msec;
					}else{
						time.GetComponent<UILabel>().text = min + ":0" + sec + ":0" + msec;
					}
				}
			}else{
				if(sec > 9){
					if(msec > 9){
						time.GetComponent<UILabel>().text = "0" + min + ":" + sec + ":" + msec;
					}else{
						time.GetComponent<UILabel>().text = "0" + min + ":" + sec + ":0" + msec;
					}
				}else{
					if(msec > 9){
						time.GetComponent<UILabel>().text = "0" + min + ":0" + sec + ":" + msec;
					}else{
						time.GetComponent<UILabel>().text = "0" + min + ":0" + sec + ":0" + msec;
					}
				}
			}
		}else{
			if(sec > 0||msec > 0){
				if(msec <= 0){
					msec = 60;
					sec --;
				}
				msec -= 6;
				
				if(sec > 9){
					if(msec > 9){
						time.GetComponent<UILabel>().text =  "00:" + sec + ":" + msec;
					}else{
						time.GetComponent<UILabel>().text =  "00:" + sec + ":0" + msec;
					}
				}else{
					if(msec > 9){
						time.GetComponent<UILabel>().text =  "00:0" + sec + ":" + msec;
					}else{
						time.GetComponent<UILabel>().text =  "00:0" + sec + ":0" + msec;
					}
				}
			}
		}
	}

//	void timing(){
//		if((Application.loadedLevel > 1)&&(Application.loadedLevel != 13)){
//			if(timeType < 0){
//				msec += 6;
//				if(min >= 60){
//					min = 0;
//					sec = 0;
//					msec = 0;
//				}
//				
//				if(sec >= 60){
//					sec = 0;
//					min ++;
//				}
//				
//				if(msec >= 60){
//					msec = 0;
//					sec ++;
//				}
//				
//				if(min > 9){
//					if(sec > 9){
//						if(msec > 9){
//							time.GetComponent<UILabel>().text = min + ":" + sec + ":" + msec;
//						}else{
//							time.GetComponent<UILabel>().text = min + ":" + sec + ":0" + msec;
//						}
//					}else{
//						if(msec > 9){
//							time.GetComponent<UILabel>().text = min + ":0" + sec + ":" + msec;
//						}else{
//							time.GetComponent<UILabel>().text = min + ":0" + sec + ":0" + msec;
//						}
//					}
//				}else{
//					if(sec > 9){
//						if(msec > 9){
//							time.GetComponent<UILabel>().text = "0" + min + ":" + sec + ":" + msec;
//						}else{
//							time.GetComponent<UILabel>().text = "0" + min + ":" + sec + ":0" + msec;
//						}
//					}else{
//						if(msec > 9){
//							time.GetComponent<UILabel>().text = "0" + min + ":0" + sec + ":" + msec;
//						}else{
//							time.GetComponent<UILabel>().text = "0" + min + ":0" + sec + ":0" + msec;
//						}
//					}
//				}
//			}else{
//				if(sec > 0||msec > 0){
//					if(msec <= 0){
//						msec = 60;
//						sec --;
//					}
//					msec -= 6;
//					
//					if(sec > 9){
//						if(msec > 9){
//							time.GetComponent<UILabel>().text =  "00:" + sec + ":" + msec;
//						}else{
//							time.GetComponent<UILabel>().text =  "00:" + sec + ":0" + msec;
//						}
//					}else{
//						if(msec > 9){
//							time.GetComponent<UILabel>().text =  "00:0" + sec + ":" + msec;
//						}else{
//							time.GetComponent<UILabel>().text =  "00:0" + sec + ":0" + msec;
//						}
//					}
//				}
//			}
//		}
//	}


	public void OnMenuClick(){
		Application.LoadLevel (1);
	}

	public void OnMenuClickAnother(){
		int health = PlayerPrefs.GetInt ("health");
//		if (health == 1) {
//			NGUITools.SetActive (gameOverWait,true);
//			NGUITools.SetActive (des,false);
//		} else {
			Application.LoadLevel (1);
//		}
		health --;
		PlayerPrefs.SetInt ("health",health);
	}
	
	public void OnStartClick(){
		NGUITools.SetActive (des,false);
		GameObject.FindGameObjectWithTag ("GameController").SendMessage ("StartCountDown");
	}
	
	public void OnRestartClickPause(){
		int health = PlayerPrefs.GetInt ("health");

		if(health == 1){
			NGUITools.SetActive (des,false);
			NGUITools.SetActive (gameOverWait,true);
		}else{
			PlayerPrefs.SetInt("restart",1);
			Application.LoadLevel (Application.loadedLevel);
		}

		health --;
		PlayerPrefs.SetInt ("health",health);
	}

	public void OnRestartClickSuccess(){
		int health = PlayerPrefs.GetInt ("health");
		
		if(health == 1){
			PlayerPrefs.SetInt("successMark",1);
			Debug.Log(success);
			NGUITools.SetActive (success,false);
			NGUITools.SetActive (gameOverWait,true);
		}else{
			PlayerPrefs.SetInt("restart",1);
			Application.LoadLevel (Application.loadedLevel);
		}
		
		health --;
		PlayerPrefs.SetInt ("health",health);
	}

	public void OnRestartClickFail(){
		PlayerPrefs.SetInt("restart",1);
		Application.LoadLevel (Application.loadedLevel);
	}
	
	public void OnResumeClick(){
		Time.timeScale = 1;
		NGUITools.SetActive (des,false);
	}
	
	public void OnPauseButtonClick(){
		Time.timeScale = 0;
		NGUITools.SetActive (des,true);
		NGUITools.SetActive (start,false);
		NGUITools.SetActive (restart,true);
	}

	public void OnNextButtonClick(){
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	public void OnNextButtonClickAnother(){
		Application.LoadLevel (13);
	}
}
