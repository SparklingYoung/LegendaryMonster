using UnityEngine;
using System.Collections;

public class BallFreeze : MonoBehaviour {
    public AudioClip sound;
    private bool _freezed = false;
    public Sprite _freezeSprite;
    public Sprite _standardSprite;
    private AudioSource audio;

    void Start() {
        audio = GetComponent<AudioSource>();
    }

    IEnumerator FreezeAnimate() {
        GetComponent<Ball>().canStop = true;
        var oldVelocity = GetComponent<Rigidbody2D>().velocity;
        var oldAngular = GetComponent<Rigidbody2D>().angularVelocity;
        GetComponent<Rigidbody2D>().angularVelocity = 0;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Animator>().SetTrigger("Freeze");
//        gameObject.GetComponent<SpriteRenderer>().sprite = _freezeSprite;
        GameObject.FindWithTag("Respawn").GetComponent<Animator>().SetTrigger("Throng");
        yield return new WaitForSeconds(3);
//        gameObject.GetComponent<SpriteRenderer>().sprite = _standardSprite;
        GetComponent<Rigidbody2D>().velocity = oldVelocity;
        GetComponent<Rigidbody2D>().angularVelocity = oldAngular;
        GetComponent<Animator>().SetTrigger("Melt");
        GetComponent<Ball>().canStop = false;
        _freezed = false;
    }

    void Freeze() {
        if (!_freezed) {
            _freezed = true;
            audio.PlayOneShot(sound);
            StartCoroutine(FreezeAnimate());
        }
        Debug.Log("Ball freeze");
    }
}
