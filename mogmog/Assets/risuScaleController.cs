using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class risuScaleController : MonoBehaviour {

	public static int state;
	// public static int state;
	//
	// [SerializeField] GameObject gameObject;
	//
	// public bool scaleFlag0 = false;
	//
	// public bool scaleFlag1 = false;
	//
	// public bool scaleFlag2 = false;
	//
	// public bool scaleFlag3 = false;
	//
	// public bool scaleFlag4 = false;
	//
	// public bool scaleFlag5 = false;

	// Use this for initialization
	void Start () {
		if(statemanager.state == 0){
			this.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
		}else if(statemanager.state == 1){
			this.transform.localScale = new Vector3(0.6f,0.6f,0.6f);
		}else if(statemanager.state == 2){
			this.transform.localScale = new Vector3(0.9f,0.9f,0.9f);
		}else if(statemanager.state == 3){
			this.transform.localScale = new Vector3(1.2f,1.2f,1.2f);
		}else if(statemanager.state == 4){
			this.transform.localScale = new Vector3(1.5f,1.5f,1.5f);
		}else if(statemanager.state == 5){
			this.transform.localScale = new Vector3(1.8f,1.8f,1.8f);
		}
	}

	// Update is called once per frame
	void Update () {

		// if(state == 0){
		// 	scaleFlag0 = true;
		// }else if(state == 1 && scaleFlag0 == true){
		// 	scaleFlag0 = false;
		// 	scaleFlag1 = true;
		// }else if(state == 2 && scaleFlag1 == true){
		// 	scaleFlag1 = false;
		// 	scaleFlag2 = true;
		// }else if(state == 3 && scaleFlag2 == true){
		// 	scaleFlag2 = false;
		// 	scaleFlag3 = true;
		// }else if(state == 4 && scaleFlag3 == true){
		// 	scaleFlag3 = false;
		// 	scaleFlag4 = true;
		// }else if(state == 5 && scaleFlag3 == true){
		// 	scaleFlag4 = false;
		// 	scaleFlag5 = true;
		// }
		//
		// if(scaleFlag0 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 0.3f, this.transform.localScale.y * 0.3f, this.transform.localScale.z * 0.3f);
		// }else if(scaleFlag1 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 1.3f, this.transform.localScale.y * 1.3f, this.transform.localScale.z * 1.3f);
		// }else if(scaleFlag2 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 1.3f, this.transform.localScale.y * 1.3f, this.transform.localScale.z * 1.3f);
		// }else if(scaleFlag3 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 1.3f, this.transform.localScale.y * 1.3f, this.transform.localScale.z * 1.3f);
		// }else if(scaleFlag4 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 1.3f, this.transform.localScale.y * 1.3f, this.transform.localScale.z * 1.3f);
		// }else if(scaleFlag5 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 1.3f, this.transform.localScale.y * 1.3f, this.transform.localScale.z * 1.3f);
		// }
	}
}
