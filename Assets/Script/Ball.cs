using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public int life = 3;
    public float velosityScale;
    public Vector2 velosity;
    public bool canStop = false;

	// Use this for initialization
	void Start () {
        velosity = velosity.normalized * velosityScale;
	    GetComponent<Rigidbody2D>().velocity = velosity;
	}
	
	// Update is called once per frame
	void Update () {
	    var tmp = GetComponent<Rigidbody2D>().velocity;
        GetComponent<Rigidbody2D>().velocity = tmp.normalized * velosityScale;
    }

    void FixedUpdate() {
        if (life < 0) {
            GameObject.FindWithTag("GameController").GetComponent<GameManager>().Failed();
        }
    }

    void SpeedUp(float factor) {
        velosityScale = Mathf.Min(25, velosityScale*factor);
//        velosityScale *= factor;
        Debug.Log(velosityScale);
    }

    void LifeMinusOne() {
        life--;
    }
}
