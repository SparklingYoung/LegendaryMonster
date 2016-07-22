using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	private int level;
	private int health;

	void Start(){

		level = PlayerPrefs.GetInt ("level");
	}
	
	public void OnLevel1Click(){
		health = PlayerPrefs.GetInt ("health");
		if(level >= 1&&health >= 1){
			PlayerPrefs.SetInt("restart",0);
			Application.LoadLevel (Application.loadedLevel + 1);
		}
	}
	
	public void OnLevel2Click(){
		health = PlayerPrefs.GetInt ("health");
		if (level >= 2&&health >= 1) {
			PlayerPrefs.SetInt("restart",0);
			Application.LoadLevel (Application.loadedLevel + 2);
		}
	}
	
	public void OnLevel3Click(){
		health = PlayerPrefs.GetInt ("health");
		if(level >= 3&&health >= 1){
			PlayerPrefs.SetInt("restart",0);
			Application.LoadLevel (Application.loadedLevel + 3);
		}
	}
	
	public void OnLevel4Click(){
		health = PlayerPrefs.GetInt ("health");
		if (level >= 4&&health >= 1) {
			PlayerPrefs.SetInt("restart",0);
			Application.LoadLevel (Application.loadedLevel + 4);
		}
	}
	
	public void OnLevel5Click(){
		health = PlayerPrefs.GetInt ("health");
		if (level >= 5&&health >= 1) {
			PlayerPrefs.SetInt("restart",0);
			Application.LoadLevel (Application.loadedLevel + 5);
		}
	}
	
	public void OnLevel6Click(){
		health = PlayerPrefs.GetInt ("health");
		if (level >= 6&&health >= 1) {
			PlayerPrefs.SetInt("restart",0);
			Application.LoadLevel (Application.loadedLevel + 6);
		}
	}
	
	public void OnLevel7Click(){
		health = PlayerPrefs.GetInt ("health");
		if (level >= 7&&health >= 1) {
			PlayerPrefs.SetInt("restart",0);
			Application.LoadLevel (Application.loadedLevel + 7);
		}
	}
	
	public void OnLevel8Click(){
		health = PlayerPrefs.GetInt ("health");
		if (level >= 8&&health >= 1) {
			PlayerPrefs.SetInt("restart",0);
			Application.LoadLevel (Application.loadedLevel + 8);
		}
	}
	
	public void OnLevel9Click(){
		health = PlayerPrefs.GetInt ("health");
		if (level >= 9&&health >= 1) {
			PlayerPrefs.SetInt("restart",0);
			Application.LoadLevel (Application.loadedLevel + 9);
		}
	}
	
	public void OnLevel10Click(){
		health = PlayerPrefs.GetInt ("health");
		if (level >= 10&&health >= 1) {
			PlayerPrefs.SetInt("restart",0);
			Application.LoadLevel (Application.loadedLevel + 10);
		}
	}

    public void OnQuitClick() {
        Application.Quit();
    }
}
