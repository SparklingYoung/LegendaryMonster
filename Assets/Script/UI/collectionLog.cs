using UnityEngine;
using System.Collections;

public class collectionLog : MonoBehaviour {
	private int lv1col;
	private int lv2col;
	private int lv3col;
	private int lv4col;
	private int lv5col;
	private int lv6col;
	private int lv7col;
	private int lv8col;
	private int lv9col;
	private int lv10col;

	private GameObject lv1col1;
	private GameObject lv1col2;
    private GameObject lv1colGray1;
    private GameObject lv1colGray2;
    private GameObject lv2col1;
	private GameObject lv2col2;
    private GameObject lv2colGray1;
    private GameObject lv2colGray2;
    private GameObject lv3col1;
	private GameObject lv3col2;
    private GameObject lv3colGray1;
    private GameObject lv3colGray2;
    private GameObject lv4col1;
	private GameObject lv4col2;
    private GameObject lv4colGray1;
    private GameObject lv4colGray2;
    private GameObject lv5col1;
	private GameObject lv5col2;
    private GameObject lv5colGray1;
    private GameObject lv5colGray2;
    private GameObject lv6col1;
	private GameObject lv6col2;
    private GameObject lv6colGray1;
    private GameObject lv6colGray2;
    private GameObject lv7col1;
	private GameObject lv7col2;
    private GameObject lv7colGray1;
    private GameObject lv7colGray2;
    private GameObject lv8col1;
	private GameObject lv8col2;
    private GameObject lv8colGray1;
    private GameObject lv8colGray2;
    private GameObject lv9col1;
	private GameObject lv9col2;
    private GameObject lv9colGray1;
    private GameObject lv9colGray2;
    private GameObject lv10col1;
	private GameObject lv10col2;
    private GameObject lv10colGray1;
    private GameObject lv10colGray2;


    void Start(){
		if(!PlayerPrefs.HasKey("lv1col")){
			PlayerPrefs.SetInt("lv1col",0);
		}

		if(!PlayerPrefs.HasKey("lv2col")){
			PlayerPrefs.SetInt("lv2col",0);
		}

		if(!PlayerPrefs.HasKey("lv3col")){
			PlayerPrefs.SetInt("lv3col",0);
		}

		if(!PlayerPrefs.HasKey("lv4col")){
			PlayerPrefs.SetInt("lv4col",0);
		}

		if(!PlayerPrefs.HasKey("lv5col")){
			PlayerPrefs.SetInt("lv5col",0);
		}

		if(!PlayerPrefs.HasKey("lv6col")){
			PlayerPrefs.SetInt("lv6col",0);
		}

		if(!PlayerPrefs.HasKey("lv7col")){
			PlayerPrefs.SetInt("lv7col",0);
		}

		if(!PlayerPrefs.HasKey("lv8col")){
			PlayerPrefs.SetInt("lv8col",0);
		}

		if(!PlayerPrefs.HasKey("lv9col")){
			PlayerPrefs.SetInt("lv9col",0);
		}

		if(!PlayerPrefs.HasKey("lv10col")){
			PlayerPrefs.SetInt("lv10col",0);
		}

		lv1col = PlayerPrefs.GetInt ("lv1col");
		lv2col = PlayerPrefs.GetInt ("lv2col");
		lv3col = PlayerPrefs.GetInt ("lv3col");
		lv4col = PlayerPrefs.GetInt ("lv4col");
		lv5col = PlayerPrefs.GetInt ("lv5col");
		lv6col = PlayerPrefs.GetInt ("lv6col");
		lv7col = PlayerPrefs.GetInt ("lv7col");
		lv8col = PlayerPrefs.GetInt ("lv8col");
		lv9col = PlayerPrefs.GetInt ("lv9col");
		lv10col = PlayerPrefs.GetInt ("lv10col");

		lv1col1 = GameObject.Find ("lv1col1");
		lv1col2 = GameObject.Find ("lv1col2");
        lv1colGray1 = GameObject.Find("lv1colGray1");
        lv1colGray2 = GameObject.Find("lv1colGray2");
        lv2col1 = GameObject.Find ("lv2col1");
		lv2col2 = GameObject.Find ("lv2col2");
        lv2colGray1 = GameObject.Find("lv2colGray1");
        lv2colGray2 = GameObject.Find("lv2colGray2");
        lv3col1 = GameObject.Find ("lv3col1");
		lv3col2 = GameObject.Find ("lv3col2");
        lv3colGray1 = GameObject.Find("lv3colGray1");
        lv3colGray2 = GameObject.Find("lv3colGray2");
        lv4col1 = GameObject.Find ("lv4col1");
		lv4col2 = GameObject.Find ("lv4col2");
        lv4colGray1 = GameObject.Find("lv4colGray1");
        lv4colGray2 = GameObject.Find("lv4colGray2");
        lv5col1 = GameObject.Find ("lv5col1");
		lv5col2 = GameObject.Find ("lv5col2");
        lv5colGray1 = GameObject.Find("lv5colGray1");
        lv5colGray2 = GameObject.Find("lv5colGray2");
        lv6col1 = GameObject.Find ("lv6col1");
		lv6col2 = GameObject.Find ("lv6col2");
        lv6colGray1 = GameObject.Find("lv6colGray1");
        lv6colGray2 = GameObject.Find("lv6colGray2");
        lv7col1 = GameObject.Find ("lv7col1");
		lv7col2 = GameObject.Find ("lv7col2");
        lv7colGray1 = GameObject.Find("lv7colGray1");
        lv7colGray2 = GameObject.Find("lv7colGray2");
        lv8col1 = GameObject.Find ("lv8col1");
		lv8col2 = GameObject.Find ("lv8col2");
        lv8colGray1 = GameObject.Find("lv8colGray1");
        lv8colGray2 = GameObject.Find("lv8colGray2");
        lv9col1 = GameObject.Find ("lv9col1");
		lv9col2 = GameObject.Find ("lv9col2");
        lv9colGray1 = GameObject.Find("lv9colGray1");
        lv9colGray2 = GameObject.Find("lv9colGray2");
        lv10col1 = GameObject.Find ("lv10col1");
		lv10col2 = GameObject.Find ("lv10col2");
        lv10colGray1 = GameObject.Find("lv10colGray1");
        lv10colGray2 = GameObject.Find("lv10colGray2");

        NGUITools.SetActive(lv1col1,false);
        NGUITools.SetActive(lv1col2, false);
        NGUITools.SetActive(lv2col1, false);
        NGUITools.SetActive(lv2col2, false);
        NGUITools.SetActive(lv3col1, false);
        NGUITools.SetActive(lv3col2, false);
        NGUITools.SetActive(lv4col1, false);
        NGUITools.SetActive(lv4col2, false);
        NGUITools.SetActive(lv5col1, false);
        NGUITools.SetActive(lv5col2, false);
        NGUITools.SetActive(lv6col1, false);
        NGUITools.SetActive(lv6col2, false);
        NGUITools.SetActive(lv7col1, false);
        NGUITools.SetActive(lv7col2, false);
        NGUITools.SetActive(lv8col1, false);
        NGUITools.SetActive(lv8col2, false);
        NGUITools.SetActive(lv9col1, false);
        NGUITools.SetActive(lv9col2, false);
        NGUITools.SetActive(lv10col1, false);
        NGUITools.SetActive(lv10col2, false);
    }



    void Update() {
        switch (lv1col) {
            case 0:
                NGUITools.SetActive(lv1colGray1, true);
                NGUITools.SetActive(lv1colGray2, true);
                NGUITools.SetActive(lv1col1, false);
                NGUITools.SetActive(lv1col2, false);
                break;
            case 1:
                NGUITools.SetActive(lv1colGray1, false);
                NGUITools.SetActive(lv1colGray2, true);
                NGUITools.SetActive(lv1col1, true);
                NGUITools.SetActive(lv1col2, false);
                break;
            case 2:
                NGUITools.SetActive(lv1colGray1, false);
                NGUITools.SetActive(lv1colGray2, false);
                NGUITools.SetActive(lv1col1, true);
                NGUITools.SetActive(lv1col2, true);
                break;
        }

        switch (lv2col) {
            case 0:
                NGUITools.SetActive(lv2colGray1, true);
                NGUITools.SetActive(lv2colGray2, true);
                NGUITools.SetActive(lv2col1, false);
                NGUITools.SetActive(lv2col2, false);
                break;
            case 1:
                NGUITools.SetActive(lv2colGray1, false);
                NGUITools.SetActive(lv2colGray2, true);
                NGUITools.SetActive(lv2col1, true);
                NGUITools.SetActive(lv2col2, false);
                break;
            case 2:
                NGUITools.SetActive(lv2colGray1, false);
                NGUITools.SetActive(lv2colGray2, false);
                NGUITools.SetActive(lv2col1, true);
                NGUITools.SetActive(lv2col2, true);
                break;
        }


        switch (lv3col) {
            case 0:
                NGUITools.SetActive(lv3colGray1, true);
                NGUITools.SetActive(lv3colGray2, true);
                NGUITools.SetActive(lv3col1, false);
                NGUITools.SetActive(lv3col2, false);
                break;
            case 1:
                NGUITools.SetActive(lv3colGray1, false);
                NGUITools.SetActive(lv3colGray2, true);
                NGUITools.SetActive(lv3col1, true);
                NGUITools.SetActive(lv3col2, false);
                break;
            case 2:
                NGUITools.SetActive(lv3colGray1, false);
                NGUITools.SetActive(lv3colGray2, false);
                NGUITools.SetActive(lv3col1, true);
                NGUITools.SetActive(lv3col2, true);
                break;
        }


        switch (lv4col) {
            case 0:
                NGUITools.SetActive(lv4colGray1, true);
                NGUITools.SetActive(lv4colGray2, true);
                NGUITools.SetActive(lv4col1, false);
                NGUITools.SetActive(lv4col2, false);
                break;
            case 1:
                NGUITools.SetActive(lv4colGray1, false);
                NGUITools.SetActive(lv4colGray2, true);
                NGUITools.SetActive(lv4col1, true);
                NGUITools.SetActive(lv4col2, false);
                break;
            case 2:
                NGUITools.SetActive(lv4colGray1, false);
                NGUITools.SetActive(lv4colGray2, false);
                NGUITools.SetActive(lv4col1, true);
                NGUITools.SetActive(lv4col2, true);
                break;
        }

        switch (lv5col) {
            case 0:
                NGUITools.SetActive(lv5colGray1, true);
                NGUITools.SetActive(lv5colGray2, true);
                NGUITools.SetActive(lv5col1, false);
                NGUITools.SetActive(lv5col2, false);
                break;
            case 1:
                NGUITools.SetActive(lv5colGray1, false);
                NGUITools.SetActive(lv5colGray2, true);
                NGUITools.SetActive(lv5col1, true);
                NGUITools.SetActive(lv5col2, false);
                break;
            case 2:
                NGUITools.SetActive(lv5colGray1, false);
                NGUITools.SetActive(lv5colGray2, false);
                NGUITools.SetActive(lv5col1, true);
                NGUITools.SetActive(lv5col2, true);
                break;
        }

        switch (lv6col) {
            case 0:
                NGUITools.SetActive(lv6colGray1, true);
                NGUITools.SetActive(lv6colGray2, true);
                NGUITools.SetActive(lv6col1, false);
                NGUITools.SetActive(lv6col2, false);
                break;
            case 1:
                NGUITools.SetActive(lv6colGray1, false);
                NGUITools.SetActive(lv6colGray2, true);
                NGUITools.SetActive(lv6col1, true);
                NGUITools.SetActive(lv6col2, false);
                break;
            case 2:
                NGUITools.SetActive(lv6colGray1, false);
                NGUITools.SetActive(lv6colGray2, false);
                NGUITools.SetActive(lv6col1, true);
                NGUITools.SetActive(lv6col2, true);
                break;
        }


        switch (lv7col) {
            case 0:
                NGUITools.SetActive(lv7colGray1, true);
                NGUITools.SetActive(lv7colGray2, true);
                NGUITools.SetActive(lv7col1, false);
                NGUITools.SetActive(lv7col2, false);
                break;
            case 1:
                NGUITools.SetActive(lv7colGray1, false);
                NGUITools.SetActive(lv7colGray2, true);
                NGUITools.SetActive(lv7col1, true);
                NGUITools.SetActive(lv7col2, false);
                break;
            case 2:
                NGUITools.SetActive(lv7colGray1, false);
                NGUITools.SetActive(lv7colGray2, false);
                NGUITools.SetActive(lv7col1, true);
                NGUITools.SetActive(lv7col2, true);
                break;
        }

        switch (lv8col) {
            case 0:
                NGUITools.SetActive(lv8colGray1, true);
                NGUITools.SetActive(lv8colGray2, true);
                NGUITools.SetActive(lv8col1, false);
                NGUITools.SetActive(lv8col2, false);
                break;
            case 1:
                NGUITools.SetActive(lv8colGray1, false);
                NGUITools.SetActive(lv8colGray2, true);
                NGUITools.SetActive(lv8col1, true);
                NGUITools.SetActive(lv8col2, false);
                break;
            case 2:
                NGUITools.SetActive(lv8colGray1, false);
                NGUITools.SetActive(lv8colGray2, false);
                NGUITools.SetActive(lv8col1, true);
                NGUITools.SetActive(lv8col2, true);
                break;
        }

        switch (lv9col) {
            case 0:
                NGUITools.SetActive(lv9colGray1, true);
                NGUITools.SetActive(lv9colGray2, true);
                NGUITools.SetActive(lv9col1, false);
                NGUITools.SetActive(lv9col2, false);
                break;
            case 1:
                NGUITools.SetActive(lv9colGray1, false);
                NGUITools.SetActive(lv9colGray2, true);
                NGUITools.SetActive(lv9col1, true);
                NGUITools.SetActive(lv9col2, false);
                break;
            case 2:
                NGUITools.SetActive(lv9colGray1, false);
                NGUITools.SetActive(lv9colGray2, false);
                NGUITools.SetActive(lv9col1, true);
                NGUITools.SetActive(lv9col2, true);
                break;
        }

        switch (lv10col) {
            case 0:
                NGUITools.SetActive(lv10colGray1, true);
                NGUITools.SetActive(lv10colGray2, true);
                NGUITools.SetActive(lv10col1, false);
                NGUITools.SetActive(lv10col2, false);
                break;
            case 1:
                NGUITools.SetActive(lv10colGray1, false);
                NGUITools.SetActive(lv10colGray2, true);
                NGUITools.SetActive(lv10col1, true);
                NGUITools.SetActive(lv10col2, false);
                break;
            case 2:
                NGUITools.SetActive(lv10colGray1, false);
                NGUITools.SetActive(lv10colGray2, false);
                NGUITools.SetActive(lv10col1, true);
                NGUITools.SetActive(lv10col2, true);
                break;
        }
    }

}
