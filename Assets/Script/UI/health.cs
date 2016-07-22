using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {
	private GameObject health0;
	private GameObject health1;
	private GameObject health2;
	private GameObject health3;
	private GameObject health4;
	private GameObject health5;
	private int healthState;

	// Use this for initialization
	void Start () {
		health0 = GameObject.Find ("health0");
		health1 = GameObject.Find ("health1");
		health2 = GameObject.Find ("health2");
		health3 = GameObject.Find ("health3");
		health4 = GameObject.Find ("health4");
		health5 = GameObject.Find ("health5");
		NGUITools.SetActive (health0,false);
		NGUITools.SetActive (health1,false);
		NGUITools.SetActive (health2,false);
		NGUITools.SetActive (health3,false);
		NGUITools.SetActive (health4,false);
		NGUITools.SetActive (health5,false);

		if(!PlayerPrefs.HasKey("health")){
			PlayerPrefs.SetInt("health",5);
		}

		healthState = PlayerPrefs.GetInt ("health");
		switch(healthState){
		case 0:
			NGUITools.SetActive(health0,true);
			break;
		case 1:
			NGUITools.SetActive(health1,true);
			break;
		case 2:
			NGUITools.SetActive(health2,true);
			break;
		case 3:
			NGUITools.SetActive(health3,true);
			break;
		case 4:
			NGUITools.SetActive(health4,true);
			break;
		case 5:
			NGUITools.SetActive(health5,true);
			break;
		}
	}

	void Update(){
		NGUITools.SetActive (health0,false);
		NGUITools.SetActive (health1,false);
		NGUITools.SetActive (health2,false);
		NGUITools.SetActive (health3,false);
		NGUITools.SetActive (health4,false);
		NGUITools.SetActive (health5,false);

		healthState = PlayerPrefs.GetInt ("health");

		switch(healthState){
		case 0:
			NGUITools.SetActive(health0,true);
			break;
		case 1:
			NGUITools.SetActive(health1,true);
			break;
		case 2:
			NGUITools.SetActive(health2,true);
			break;
		case 3:
			NGUITools.SetActive(health3,true);
			break;
		case 4:
			NGUITools.SetActive(health4,true);
			break;
		case 5:
			NGUITools.SetActive(health5,true);
			break;
		}
	}
}
