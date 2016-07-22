using UnityEngine;
using System.Collections;

public class welEvent : MonoBehaviour {
	public MovieTexture indexTexture;
	public MovieTexture desTexture;
	public TweenPosition indexTween;
	public TweenPosition desTween;
	public GameObject pre;
	private bool flagIndex;
	private GameObject video1;
	public GameObject video2;
	private GameObject bgMusic;
	private int delay;
	private bool delayMark;
    private bool endMark;
	

	void Start(){
		video1 = GameObject.Find ("video1");
		video1.GetComponent<AudioSource> ().enabled = false;
		video1.SetActive (false);
		delay = 0;
		delayMark = false;
	    endMark = false;
		InvokeRepeating("timing",1,1f);
	}

	void timing(){
		delay ++;
		if((delay > 5)&&(!delayMark)){
			indexTexture.Play ();
			video1.SetActive (true);
			video1.GetComponent<AudioSource> ().enabled = true;
			flagIndex = false;
			delayMark = true;
		}
	}

	void Update(){
	    if (endMark&&(!desTexture.isPlaying)) {
	        Application.LoadLevel(Application.loadedLevel + 1);
	    }

		if(delayMark){
			if (!indexTexture.isPlaying) {
				if(!flagIndex){
					indexTween.PlayForward();
					desTween.PlayForward ();
				}
				
				flagIndex = true;
			}
			
			
			if (desTween.transform.position.y > -2) {
			    endMark = true;
			    desTexture.Play();
				bgMusic = GameObject.FindWithTag ("bgMusic");
				if(bgMusic == null){
					bgMusic = (GameObject)Instantiate(pre);
				}
				//video2.GetComponent<AudioSource>().enabled = true;
			}
			
			if(bgMusic != null){
				float volume;
				volume = bgMusic.GetComponent<AudioSource> ().volume;
				if (volume < 1.0) {
					volume += 0.01f;
					bgMusic.GetComponent<AudioSource> ().volume = volume;
				}
			}

		}
	}
	
}
