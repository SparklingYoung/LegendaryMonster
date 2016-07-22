using UnityEngine;
using System.Collections;

public class setSounds : MonoBehaviour {
	private int sounds;
	
	// Update is called once per frame
	void Update () {
		sounds = PlayerPrefs.GetInt ("sounds");
		//Debug.Log (sounds);
		bool state = gameObject.GetComponent<UIPlaySound> ().enabled;
		//Debug.Log (state);

		if (sounds == 0 && (!state)) {
			gameObject.GetComponent<UIPlaySound>().enabled = true;
		}

		if (sounds == 1 && state) {
			gameObject.GetComponent<UIPlaySound>().enabled = false;
		}
	}
}
