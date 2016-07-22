using UnityEngine;
using System.Collections;

public class Collection : MonoBehaviour {

	//zhangjingjing
	public static Vector3 pos;

    void Start() {
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Player") {
            Debug.Log("CollectionTrigger");
            GameObject.FindWithTag("GameController").GetComponent<GameManager>().AddScore();
            transform.parent.SendMessage("PlayCollection");
            Destroy(gameObject);

			//zhangjingjing
			if(gameObject.name.Equals("collection")){
				pos = GameObject.Find("collection").transform.position;
				//Debug.Log(pos);
				GameObject.FindWithTag("c1Anim").GetComponent<collectionAnimation>().playCollectionAnimation();
			}else{
				pos = GameObject.Find("collection (1)").transform.position;
				GameObject.FindWithTag("c2Anim").GetComponent<collectionAnimation>().playCollectionAnimation();
			}
        }
    }
}
