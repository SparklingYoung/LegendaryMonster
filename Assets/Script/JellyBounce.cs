using UnityEngine;
using System.Collections;

public class JellyBounce : MonoBehaviour {
    public float accelerate;
    public Sprite bounceSprite;

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Player") {
            coll.gameObject.SendMessage("SpeedUp", accelerate);
            coll.gameObject.GetComponent<SpriteRenderer>().sprite = bounceSprite;
            gameObject.GetComponent<Animator>().SetTrigger("Pump");
        }
    }
}
