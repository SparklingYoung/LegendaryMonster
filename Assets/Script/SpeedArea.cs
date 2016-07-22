using System;
using UnityEngine;
using System.Collections;

public class SpeedArea : MonoBehaviour {
    public float speedFactor;

    void OnTriggerStay2D(Collider2D collider) {
        if (collider.tag == "Player") {
            Debug.Log(collider.gameObject.GetComponent<Ball>().velosityScale);
            collider.gameObject.GetComponent<Ball>().velosityScale *= speedFactor;
            if (Math.Abs(collider.GetComponent<Rigidbody2D>().velocity.magnitude) < 0.1)
                GameObject.FindGameObjectWithTag("GameController").SendMessage("Failed");
        }
    }
}
