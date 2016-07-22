using UnityEngine;
using System.Collections;

public class Throng : MonoBehaviour {
    public GameObject player;

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag == "Bubble") {
//            foreach (Transform child in collider.transform) {
//                child.gameObject.layer = 10;
//            }
            collider.GetComponent<CircleCollider2D>().enabled = false;
            player.GetComponent<BallBubble>().RemoveBubble(collider.gameObject);
            collider.GetComponentInChildren<Bubble>().Destroy();
        }
    }
}
