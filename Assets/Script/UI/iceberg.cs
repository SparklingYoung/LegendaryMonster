using UnityEngine;
using System.Collections;

public class iceberg : MonoBehaviour {
	private int iceNum;


	// Use this for initialization
	void Start () {
		if(!PlayerPrefs.HasKey("Ice")){
			PlayerPrefs.SetInt("Ice",0);
		}
		iceNum = PlayerPrefs.GetInt ("Ice");
		GameObject.Find("iceNum").GetComponent<UILabel>().text = "+" + iceNum;
	}
	
	// Update is called once per frame
	void Update () {
		int iceNewNum;
		iceNewNum = PlayerPrefs.GetInt ("Ice");
		if(iceNum != iceNewNum){
			GameObject.Find("iceNum").GetComponent<UILabel>().text = "+" + iceNewNum;
		}
	}
}
