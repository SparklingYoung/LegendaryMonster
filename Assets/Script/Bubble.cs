using System;
using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {
    public bool dead = false;
    private bool survive = false;
    private float velosityScale = 7.5f;

    void FixedUpdate() {
        if (Math.Abs(velosityScale) > 0.001 && GetComponentInParent<Rigidbody2D>() != null) {
            var tmp = GetComponentInParent<Rigidbody2D>().velocity;
            GetComponentInParent<Rigidbody2D>().velocity = tmp.normalized * velosityScale;
        }
    }

    IEnumerator CountDown() {
        yield return new WaitForSeconds(5);
        Debug.Log(survive);
        if (GetComponentInParent<Rigidbody2D>().velocity != Vector2.zero && ! survive)
            GameObject.FindWithTag("GameController").GetComponent<GameManager>().Failed();
    }

    IEnumerator WaitAndDie() {
        survive = true;
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Player" && !dead) {
            transform.parent.parent = null;
            GetComponentInParent<Rigidbody2D>().gameObject.transform.position = collider.gameObject.transform.position;
            GetComponentInParent<Rigidbody2D>().velocity = collider.gameObject.GetComponent<Rigidbody2D>().velocity;
            velosityScale = collider.gameObject.GetComponent<Ball>().velosityScale * 0.5f;
            GetComponentInParent<Rigidbody2D>().isKinematic = false;
            collider.gameObject.GetComponent<BallBubble>().AddBubble(gameObject);
            GetComponentInChildren<Animator>().SetTrigger("Throng");
            StartCoroutine(CountDown());
        }
    }

    public void Destroy() {
//        Destroy(transform.parent.GetComponent<Rigidbody2D>());
        dead = true;
        GetComponentInParent<Animator>().SetTrigger("Exit");
        GetComponentInParent<Rigidbody2D>().velocity = Vector2.zero;
        Destroy(transform.parent.gameObject, 1);
    }
}
