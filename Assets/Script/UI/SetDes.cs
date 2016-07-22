using UnityEngine;
using System.Collections;

public class SetDes : MonoBehaviour {
	public GameObject sounds;
	public GameObject music;
	private int soundsState;
	private int musicState;
	private GameObject bgMusic;
	//private bool musicFlag = true;

	void Start(){
		soundsState = PlayerPrefs.GetInt ("sounds");
		if(soundsState == 0){
			sounds.GetComponent<UISprite>().spriteName = "iconSoundsYes";
		}
		if(soundsState == 1){
			sounds.GetComponent<UISprite>().spriteName = "iconSoundsNo";
		}

		musicState = PlayerPrefs.GetInt ("music");
		//bgMusic = GameObject.FindWithTag ("bgMusic");
		if(musicState == 0){
			music.GetComponent<UISprite>().spriteName = "iconMusicYes";
			//bgMusic.GetComponent<AudioSource>().mute = false;
		}
		if(musicState == 1){
			music.GetComponent<UISprite>().spriteName = "iconMusicNo";
		}
	}


	public void OnSoundsButtonClick(){
		soundsState = PlayerPrefs.GetInt ("sounds");

		if(soundsState == 0){
			sounds.GetComponent<UISprite>().spriteName = "iconSoundsNo";
			PlayerPrefs.SetInt("sounds",1);
		}else{
			sounds.GetComponent<UISprite>().spriteName = "iconSoundsYes";
			PlayerPrefs.SetInt("sounds",0);
		}
	}
	
	public void OnMusicButtonClick(){
		musicState = PlayerPrefs.GetInt ("music");

		if (musicState == 0) {
			music.GetComponent<UISprite>().spriteName = "iconMusicNo";
			PlayerPrefs.SetInt("music",1);
			//bgMusic.GetComponent<AudioSource>().mute = true;
		} else {
			music.GetComponent<UISprite>().spriteName = "iconMusicYes";
			PlayerPrefs.SetInt("music",0);
			//bgMusic.GetComponent<AudioSource>().mute = false;
		}
	}
	

	public void OnDescriptionClick(){
		Application.LoadLevel (12);
	}
}
