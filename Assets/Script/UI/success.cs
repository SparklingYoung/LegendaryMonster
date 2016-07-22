using UnityEngine;
using System.Collections;

public class success : MonoBehaviour {
	public MovieTexture successMovie;

	void Start(){
		successMovie.Play ();
	}

	void Update(){
		if(!successMovie.isPlaying){
			Application.LoadLevel(1);
		}
	}
}
