using UnityEngine;
using System.Collections;

public class Blackhole : MonoBehaviour {
    public int totalBounce = 8;
    public float delayTime = 10;

    IEnumerator StartDark() {
        float darkPerFrame = 1.0f/(totalBounce*delayTime);
        var tmp = gameObject.GetComponent<SpriteRenderer>().color;
        var tmpA = tmp.a;
        for (int i = 0; i < delayTime; i++) {
            tmpA += darkPerFrame;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(tmp.r, tmp.g, tmp.b, tmpA);
            yield return new WaitForFixedUpdate();
        }
    }

    public void Hit() {
        var tmp = gameObject.GetComponent<SpriteRenderer>().color;
        if (tmp.a + 1.0f / totalBounce >= 1 + 1 / totalBounce)
            GameObject.FindWithTag("GameController").SendMessage("Failed");
        StartCoroutine(StartDark());
    }
}
