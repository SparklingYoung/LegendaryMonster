using UnityEngine;
using System.Collections;

public class PortalOut : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Player")
            GameObject.FindGameObjectWithTag("GameController").SendMessage("Success");
    }
}
