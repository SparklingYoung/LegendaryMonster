using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {
    public float velosity;

	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.forward, velosity);
	
	}
}
