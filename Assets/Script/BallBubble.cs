using UnityEngine;
using System.Collections;

public class BallBubble : MonoBehaviour {
    private GameObject bubble;

	// Use this for initialization
	void Start () {
	    bubble = null;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (bubble != null && !bubble.GetComponent<Bubble>().dead) {
	        gameObject.GetComponent<Rigidbody2D>().velocity = bubble.transform.parent.GetComponent<Rigidbody2D>().velocity;
	    }
	}

    void LateUpdate() {
        if (bubble != null && !bubble.GetComponent<Bubble>().dead) {
            gameObject.transform.position = bubble.transform.position;
        }
    }

    public void AddBubble(GameObject b) {
        bubble = b;
//        gameObject.GetComponent<Rigidbody2D>().enabled = false;
//        gameObject.layer = 10;
//        gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
    }

    public void RemoveBubble(GameObject b) {
        if (bubble == b) {
            GetComponent<Rigidbody2D>().velocity = b.GetComponent<Rigidbody2D>().velocity;
            bubble = null;
        }
//        gameObject.GetComponent<Rigidbody2D>().enabled = true;
        //        gameObject.layer = 9;

    }
}
