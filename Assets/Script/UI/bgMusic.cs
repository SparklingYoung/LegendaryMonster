using UnityEngine;
using System.Collections;

public class bgMusic : MonoBehaviour {
	public GameObject pre;
	private GameObject obj;
	private int musicState;

	void Start(){
		obj = GameObject.FindWithTag ("bgMusic");
		if(obj == null){
			obj = (GameObject)Instantiate(pre);
		}

		musicState = PlayerPrefs.GetInt ("music");
		if(musicState == 0){
			obj.GetComponent<AudioSource>().mute = false;
		}
		if(musicState == 1){
			obj.GetComponent<AudioSource>().mute = true;
		}
	}

	void Update(){
		float volume;
		volume = obj.GetComponent<AudioSource> ().volume;
		if (volume < 1.0) {
			volume += 0.01f;
			obj.GetComponent<AudioSource> ().volume = volume;
		}
	}
}
