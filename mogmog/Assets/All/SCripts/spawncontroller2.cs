using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncontroller2 : MonoBehaviour {
	public GameObject target;
	public float[] Spawner  = new float[3];



	int randSPN;

	int randTime;
	// Use this for initialization
	void Start () {
		InvokeRepeating("spawner",2f,10f);
	}

	// Update is called once per frame
	void Update () {

	}

	void spawner(){
if(statemanager.Timeflag == 0){ 
		for(int i = 3; i>0; --i){
			randSPN = Random.Range(0,3);
			randTime = Random.Range(0,3);
		Instantiate (target, new Vector3(Spawner[randSPN],0,-0.8f + Spawner[randTime]),Quaternion.identity);
		Debug.Log("drop");
		}
	}


	}
}
