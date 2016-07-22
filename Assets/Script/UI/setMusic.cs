using UnityEngine;
using System.Collections;

public class setMusic : MonoBehaviour {
	public GameObject pre;
	private int music;
	private GameObject bgMusic;

	void Start(){
		bgMusic = GameObject.FindWithTag ("bgMusic");
		if(bgMusic == null){
			bgMusic = (GameObject)Instantiate(pre);
		}
	}
	
	// Update is called once per frame
	void Update () {
		music = PlayerPrefs.GetInt ("music");
		bool state;

		state = bgMusic.GetComponent<AudioSource> ().mute;

		if (music == 0 && state) {
			bgMusic.GetComponent<AudioSource> ().mute = false;
		}
		
		if (music == 1 && (!state)) {
			bgMusic.GetComponent<AudioSource> ().mute = true;
		}
	}
}
