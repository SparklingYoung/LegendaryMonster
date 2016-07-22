using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {
    public GameObject anotherPortal;
    private bool appear = false;
    private Collider2D col;
    private Vector2 vel;

    IEnumerator WaitAndAppear(Collider2D collider) {
        collider.GetComponent<Ball>().canStop = true;
        vel = collider.gameObject.GetComponent<Rigidbody2D>().velocity;
        collider.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        collider.gameObject.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        appear = true;
        col = collider;
    }

    void LateUpdate() {
        if (appear) {
            anotherPortal.GetComponentInChildren<Animator>().SetTrigger("Out");
            col.transform.position = anotherPortal.transform.position * 0.8f;
            col.gameObject.GetComponent<Rigidbody2D>().velocity = vel;
            col.gameObject.GetComponent<Renderer>().enabled = true;
            col.GetComponent<Ball>().canStop = false;
            appear = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Player") {
            GetComponentInChildren<Animator>().SetTrigger("Into");
            StartCoroutine(WaitAndAppear(collider));
        }
    }

}
