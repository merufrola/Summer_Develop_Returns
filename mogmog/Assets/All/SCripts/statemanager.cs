using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statemanager : MonoBehaviour {

public static int state = 0;
public static int point = 0;
public static bool haregrab = false;
public static bool foxgrab = false;
public static bool wolfgrab = false;
public static bool beargrab = false;
public static bool humangrab = false;
public static int Timeflag = 0;
public static int SceneFlag = 0;




	// Use this for initialization
	void Start () {
SceneFlag = 0;
	}

	// Update is called once per frame
	void Update () {

		Debug.Log(state);
if(point<5){
	//どんぐり
	state = 0;
}
else if(point>=5 && point<15){
	//うさぎ
	state = 1;
	haregrab = true;
}
else if(point>=15 && point<35){
	//きつね
	state = 2;
	foxgrab = true;
}
else if(point>=35 && point<75){
	//おおかみ
	state = 3;
	wolfgrab = true;
}
else if(point>=75 && point<155){
	//くま
	state = 4;
	wolfgrab = true;
}else if(point>=1000){
	//ゲーム終了
	state = 5;
}






	}
}
