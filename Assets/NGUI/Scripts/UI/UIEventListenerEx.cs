using UnityEngine;
using System.Collections;

public class UIEventListenerEx : UIEventListener {
	private bool mIsOpenClickSound = true;

	void OnClick(){
		if(onClick != null){
			if(mIsOpenClickSound){
				Debug.Log(gameObject);
				//gameObject.GetComponent<BoxCollider>().enabled = false;
			}

			onClick(gameObject);
		}
	}

	static public UIEventListenerEx GetEx(GameObject go){
		UIEventListenerEx listener = go.GetComponent<UIEventListenerEx>();
		if(listener == null) listener = go.AddComponent<UIEventListenerEx>();
		return listener;
	}
}
