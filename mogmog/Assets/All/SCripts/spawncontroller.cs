using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncontroller : MonoBehaviour {
public GameObject[] type;
public int[] Spawner  = new int[3];
public int[] Goal = new int[4];
int randTYPE;
int randSPN;
int randGOAL;
int randTIME;


	// Use this for initialization
	void Start () {
		//敵生成を繰り返すための関数
InvokeRepeating("spawner",2f,2f);
	}

	// Update is called once per frame
	void Update () {

	}
//敵生成関数
void spawner(){
	if(statemanager.Timeflag == 0){
	randTYPE = Random.Range(0,4);
	randSPN = Random.Range(0,3);

	Instantiate (type[randTYPE], new Vector3(Spawner[randSPN],0.7f,18.5f),Quaternion.identity);
}
}

}
