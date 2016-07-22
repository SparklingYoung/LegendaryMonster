using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Player") {
            collider.gameObject.GetComponent<Ball>().life -= 100;
        }
    }
}
