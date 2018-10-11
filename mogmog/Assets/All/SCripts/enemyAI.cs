using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour {


public Transform target;
int randGOAL;
int flag = 0;
Animator animator ;

// [SerializeField]
// public GameObject bear;
//
// [SerializeField]
// public GameObject fox;

	// Use this for initialization
	void Start () {
// InvokeRepeating("rand",5f,5f);
//フードセンサの位置を取得(プレイヤーめがけて動かない場合は必要ない)
target = GameObject.Find("foodsencer").transform;



//animator = GetComponent<Animator>;
	}

	// Update is called once per frame
	void Update () {
		//プレイヤーに向かってくる場合は以下のスクリプトを解除
// if(flag == 0){
// 		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position-transform.position),1f);
//
// 		transform.position += transform.forward*0.05f;
// 	}
// 	else if(flag == 1){


// if(flag == 0){
// target = GameObject.Find("foodsencer").transform;
// transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position-transform.position),1f);
// flag = 1;
// }



//反転してしまう動物たちのためのスクリプト
if(statemanager.Timeflag == 0){

		switch(transform.tag){
			case "fox" :
			case "bear" :
			transform.position -= transform.forward*0.03f;
			break;

			case "hare" :
			case "wolf" :
			transform.position -= new Vector3(0,0,2*Time.deltaTime);
		//transform.forward*0.05f;
			break;

	}


//プレイヤーとの位置を測るためのスクリプト(プレイヤーに向かってこない場合は必要ない)
// Ray ray = new Ray(transform.position, transform.forward);
// RaycastHit hit;
// if(Physics.Raycast(ray, out hit, 10.0f)){
// 	if(hit.collider.tag == "ME"){
//
// 	float dis = hit.distance;
// 		if(dis<15){
// 			flag = 1;
// 		}
// }
//
// }



}

//Invoke("damage",10f);


	}
void damage(){
	ContollerGrabObject.GrabFlag = false;
	Destroy(this.gameObject);
}
void DestroyDamage(){
	Destroy(this.gameObject);
}

int rand(){
	randGOAL = Random.Range(0,3);
	return randGOAL;
}

// void OnTriggerEnter(Collider col){
// 	if(col.gameObject.tag == "grab"){
// 		switch(transform.tag){
// 			case "hare":
// 			if(statemanager.haregrab){
// 				SendMessage("Grab");
// 			}
// 			break;
//
// 			case "fox":
// 			if(statemanager.foxgrab){
// 				SendMessage("Grab");
// 			}
// 			break;
//
// 			case "wolf":
// 			if(statemanager.wolfgrab){
// 				SendMessage("Grab");
// 			}
// 			break;
//
// 			case "bear":
// 			if(statemanager.beargrab){
// 				SendMessage("Grab");
// 			}
// 			break;
//
//
// 		}
// 	}
// }

}
