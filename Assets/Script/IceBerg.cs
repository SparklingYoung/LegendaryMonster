using UnityEngine;
using System.Collections;

public class IceBerg : MonoBehaviour {
    private int ice = 0;

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Player") {
            coll.gameObject.SendMessage("Freeze");
            ice = PlayerPrefs.GetInt("Ice");
            PlayerPrefs.SetInt("Ice", ++ice);
            PlayerPrefs.Save();
        }
    }
}
