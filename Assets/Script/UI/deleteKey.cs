using UnityEngine;
using System.Collections;

public class deleteKey : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.DeleteAll ();
		//InvokeRepeating("timing",1,0.1f);
		//Debug.Log ("13455");
	}
	
	// Update is called once per frame
	void timing(){
		//Debug.Log ("13455");
	}
}
