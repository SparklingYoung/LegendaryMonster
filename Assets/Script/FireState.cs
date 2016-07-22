using UnityEngine;
using System.Collections.Generic;

public class FireState : MonoBehaviour {
    private int ice = 0;

    void Start() {
        ice = PlayerPrefs.GetInt("Ice");
        Debug.Log(ice);
    }

    void RemoveIce() {
        if (--ice < 0) {
            ice = 0;
            GameObject.FindWithTag("GameController").SendMessage("Failed");
        }
        PlayerPrefs.SetInt("Ice", ice);
        PlayerPrefs.Save();
    }
}
