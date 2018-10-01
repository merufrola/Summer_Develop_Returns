using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyzone : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
//プレイヤーが逃した動物を消すためのスクリプト
	void OnTriggerEnter (Collider col) {
		switch(col.gameObject.tag){

			case "hare" :
			case "fox" :
			case "wolf" :
			case "bear" :
			case "human" :

		 	Debug.Log("destroy");
		 	col.gameObject.SendMessage("damage");
			 break;
		}
// switch(col.gameObject.tag){
// 	cace "usagi"

}




}
