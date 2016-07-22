using UnityEngine;
using System.Collections;

public class IndexVideo : MonoBehaviour {
	public MovieTexture videoTexture;
	public TweenPosition indexPlayOver;

	void Start(){
		videoTexture.Play ();

		Debug.Log (videoTexture);
	}

	void Update(){
		if (!videoTexture.isPlaying) {
			indexPlayOver.PlayForward();
			//Debug.Log(GameObject.Find("Texture").transform.position.y);
			//this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y+1,0);
		}

	}

}
