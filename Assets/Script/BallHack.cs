using System;
using UnityEngine;
using System.Collections;

public class BallHack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
	    if (Math.Abs(GetComponent<Rigidbody2D>().velocity.magnitude) < 0.01) {
	        GetComponent<Rigidbody2D>().velocity = new Vector2(1.5f, 0f);
	    }
	}
}
