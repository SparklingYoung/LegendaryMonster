using UnityEngine;
using System.Collections;

public class MapSound : MonoBehaviour {
    public AudioClip sound;
    private AudioSource audio;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
    }

    public void PlayCollection() {
        audio.PlayOneShot(sound);
    }
}
