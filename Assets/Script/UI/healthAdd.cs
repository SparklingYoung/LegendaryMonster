using UnityEngine;
using System.Collections;

public class healthAdd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		int health;
		health = PlayerPrefs.GetInt ("health");
		if (health < 5) {
		}
	}
}
