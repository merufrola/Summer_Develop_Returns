using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncontroller : MonoBehaviour {
public GameObject[] type;
public float[] Spawner  = new float[3];//スポナーのx座標を格納する配列
public int[] Goal = new int[4];
int randTYPE;
int randSPN;
int randGOAL;
int randTIME;



	// Use this for initialization
	void Start () {
		//敵生成を繰り返すための関数
		Debug.Log("Start");
InvokeRepeating("spawner",2f,2f);
	}

	// Update is called once per frame
	void Update () {





	}
//敵生成関数
void spawner(){
	if(statemanager.Timeflag == 0){


	randTYPE = Random.Range(0,4);//出てくる敵の種類用乱数生成
	randSPN = Random.Range(0,3);//スポナーの位置用乱数生成

//敵の種類とスポーン位置を設定して生成
//スポーン位置は、三つのx座標が入った配列(Spawner[])の要素を乱数(randSPN)で指定。Spawner[]はInspectorで指定可能
//Quaternionはデフォルト
	Instantiate (type[randTYPE], new Vector3(Spawner[randSPN],0.7f,18.5f),Quaternion.identity);
}
}

}
