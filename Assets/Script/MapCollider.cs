using UnityEngine;
using System.Collections;

public class MapCollider : MonoBehaviour {
    public AudioClip sound;
    private AudioSource audio;

    void Start() {
        audio = GetComponent<AudioSource>();

    }


    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Player") {
            Debug.Log("MapCollider");
            audio.PlayOneShot(sound);
        }
    }

}
