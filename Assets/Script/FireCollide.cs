using UnityEngine;
using System.Collections;

public class FireCollide : MonoBehaviour {
    public AudioClip sound;
    public GameObject player;
    public GameObject stateMachine;

    void OnCollisionExit2D(Collision2D coll) {
        if (coll.gameObject.tag == "Player") {
            GetComponent<AudioSource>().PlayOneShot(sound);
            GameObject.FindGameObjectWithTag("GameController").SendMessage("RemoveIce");
            Destroy(gameObject);
        }
            
    }
}
