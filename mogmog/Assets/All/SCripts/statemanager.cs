using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class statemanager : MonoBehaviour {

public static int state = 0;
public static int point = 0;
public static bool haregrab = false;
public static bool foxgrab = false;
public static bool wolfgrab = false;
public static bool beargrab = false;
public static bool foodgrab = false;
public static int Timeflag = 0;
public static int SceneFlag = 0;




	// Use this for initialization
	void Start () {
		SceneFlag = 0;

	}

	// Update is called once per frame
	void Update () {
		// point ++;

		Debug.Log(state);
if(point<5){
	//どんぐり
	state = 0;
}
else if(point>=5 && point<15){
	//うさぎ
	state = 1;

}
else if(point>=15 && point<35){
	//きつね
	state = 2;

}
else if(point>=35 && point<75){
	//おおかみ
	state = 3;

}
else if(point>=75 && point<775){
	//くま
	state = 4;

}
else if(point>= 775){
	state = 5;
	Timeflag = 1;
	SteamVR_Fade.Start(Color.white,1f);
	Invoke("finish",2);
}






	}
	void finish(){
		Debug.Log("finish");
		SceneManager.LoadScene("FinishScene");
}
}
