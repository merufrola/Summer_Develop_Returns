using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishScripManager : MonoBehaviour {
public Text text1;
public Text text2;
public Text text3;

	// Use this for initialization
	void Start () {
		statemanager.SceneFlag = 1;
		if(statemanager.state>5){
			text1.text = "Game Complete!";
		}else{
			text1.text = "Game Over!";
		}

		text2.text = "point：" + statemanager.point;
		//text3.text = "Pull trigger to Retry";

	}

	// Update is called once per frame
	void Update () {

		// var trackedObject = GetComponent<SteamVR_TrackedObject>();
	    //      var device = SteamVR_Controller.Input((int)trackedObject.index);
		// 	 if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
		//            {
		//                Debug.Log("トリガーを深く引いた");
		// 			   SceneManager.LoadScene("risu");
		//            }

	}

	void TextManager(){








	}
}
