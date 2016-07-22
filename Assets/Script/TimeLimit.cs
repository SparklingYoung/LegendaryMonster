using UnityEngine;
using System.Collections;

public class TimeLimit : MonoBehaviour {
    public int timeLimit;

    IEnumerator timeLimitEnumerator() {
        yield return new WaitForSeconds(timeLimit);
        gameObject.SendMessage("Failed");
    }

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("Time", timeLimit);
        PlayerPrefs.Save();
	    StartCoroutine(timeLimitEnumerator());
	}
}
