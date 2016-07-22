using System;
using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
    public float rotateScale;
    public GameObject minimap ;
    public GameObject _map;
    private float _angle = 0;
    private float preRotation = 0;
//    private Rigidbody2D _map;

	// Update is called once per frame
	void FixedUpdate () {
	    _angle *= 0.9f;
	    if (Input.GetAxis("Horizontal") == 0) {
	        _angle += (preRotation - Input.acceleration.x) * 5 * rotateScale * Time.timeScale - Input.acceleration.x * rotateScale * Time.timeScale * 0.3f;
	        preRotation = Input.acceleration.x;
	    }
	    else {
            _angle += Input.GetAxis("Horizontal") * rotateScale * Time.timeScale * 0.1f;
        }
        if (Math.Abs(Input.GetAxis("Horizontal")) > 0.1) {
	        _map.transform.Rotate(0, 0, _angle);
            minimap.transform.Rotate(0, 0, _angle);
	    }
	    //            _map.AddTorque(-Input.GetAxis("Horizontal") * rotateScale * Time.timeScale);
	    else {
            _map.transform.Rotate(0, 0, _angle);
            minimap.transform.Rotate(0, 0, _angle);
        }
        //            _map.AddTorque(-Input.acceleration.x * 2 * rotateScale * Time.timeScale);

    }

    void Stop() {
        _angle = 0;
    }

}
