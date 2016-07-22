using UnityEngine;
using System.Collections;

public class ParticleEvent : MonoBehaviour {

    void OnParticleCollision(GameObject other) {
        if (other.tag == "Player") {
            Debug.Log("Particle Collide");
            other.gameObject.GetComponent<Ball>().life -= 100;
        }
    }
}
