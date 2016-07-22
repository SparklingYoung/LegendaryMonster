using UnityEngine;
using System.Collections;

public class Emit : MonoBehaviour {
	// Use this for initialization
	void Start () {
	    GetComponentInChildren<ParticleSystem>().Play();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
