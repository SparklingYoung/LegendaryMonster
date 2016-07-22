using UnityEngine;
using System.Collections;

public class BlackHoleCollide : MonoBehaviour {
    public GameObject decoration;
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Player") {
            decoration.SendMessage("Hit");
        }
    }
}
