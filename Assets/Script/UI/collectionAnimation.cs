using UnityEngine;
using System.Collections;

public class collectionAnimation : MonoBehaviour {
	private TweenPosition position;
	private TweenScale scale;
	private TweenAlpha alpha;
	private static int count;
	private Vector3 toPos;
	private Vector3 toSca;
	public  GameObject add1;
	public  GameObject add2;

	void Start(){
		count = 0;
		NGUITools.SetActive (add1,false);
		NGUITools.SetActive (add2,false);
	}

	public void playCollectionAnimation(){
		count ++;
		gameObject.transform.position = Collection.pos;
		Debug.Log (gameObject.transform.position);
		if (count == 1) {
			NGUITools.SetActive (add1,true);
			toPos = new Vector3(18.3f,6.3f,0f);
		} else {
			toPos = new Vector3(21.6f,6.3f,0f);
			NGUITools.SetActive (add2,true);
		}
		toSca = new Vector3 (1.0f,1.0f,1.0f);
		position = TweenPosition.Begin(gameObject,1.0f, toPos,true);
		scale = TweenScale.Begin (gameObject,1.0f,toSca);
	}

	public void updateCollectionLog(){
		int colNum;
		switch(Application.loadedLevel){
		case 2:
			colNum = PlayerPrefs.GetInt("lv1col");
			if(count > colNum){
				PlayerPrefs.SetInt("lv1col",count);
			}
			break;
		case 3:
			colNum = PlayerPrefs.GetInt("lv2col");
			if(count > colNum){
				PlayerPrefs.SetInt("lv2col",count);
			}
			break;
		case 4:
			colNum = PlayerPrefs.GetInt("lv3col");
			if(count > colNum){
				PlayerPrefs.SetInt("lv3col",count);
			}
			break;
		case 5:
			colNum = PlayerPrefs.GetInt("lv4col");
			if(count > colNum){
				PlayerPrefs.SetInt("lv4col",count);
			}
			break;
		case 6:
			colNum = PlayerPrefs.GetInt("lv5col");
			if(count > colNum){
				PlayerPrefs.SetInt("lv5col",count);
			}
			break;
		case 7:
			colNum = PlayerPrefs.GetInt("lv6col");
			if(count > colNum){
				PlayerPrefs.SetInt("lv6col",count);
			}
			break;
		case 8:
			colNum = PlayerPrefs.GetInt("lv7col");
			if(count > colNum){
				PlayerPrefs.SetInt("lv7col",count);
			}
			break;
		case 9:
			colNum = PlayerPrefs.GetInt("lv8col");
			if(count > colNum){
				PlayerPrefs.SetInt("lv8col",count);
			}
			break;
		case 10:
			colNum = PlayerPrefs.GetInt("lv9col");
			if(count > colNum){
				PlayerPrefs.SetInt("lv9col",count);
			}
			break;
		case 11:
			colNum = PlayerPrefs.GetInt("lv10col");
			if(count > colNum){
				PlayerPrefs.SetInt("lv10col",count);
			}
			break;
		}
	}
}
