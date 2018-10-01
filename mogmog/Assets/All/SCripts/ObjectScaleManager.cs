using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaleManager : MonoBehaviour {

	public static int state;

	[SerializeField] GameObject gameObject;

	public bool scaleFlag0 = false;

	public bool scaleFlag1 = false;

	public bool scaleFlag2 = false;

	public bool scaleFlag3 = false;

	public bool scaleFlag4 = false;

	public bool scaleFlag5 = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(statemanager.state == 0){
			scaleFlag0 = true;
		}else if(statemanager.state == 1){

			scaleFlag1 = true;
		}else if(statemanager.state == 2 && scaleFlag1 == true){

			scaleFlag2 = true;
		}else if(statemanager.state == 3 && scaleFlag2 == true){

			scaleFlag3 = true;
		}else if(statemanager.state == 4 && scaleFlag3 == true){

			scaleFlag4 = true;
		}else if(statemanager.state == 5 && scaleFlag3 == true){

			scaleFlag5 = true;
		}

		if(scaleFlag0 == true){
			this.transform.localScale = new Vector3(this.transform.localScale.x * 1.0f, this.transform.localScale.y * 1.0f, this.transform.localScale.z * 1.0f);
			scaleFlag0 = false;
		}else if(scaleFlag1 == true){
			this.transform.localScale = new Vector3(this.transform.localScale.x * 0.8f, this.transform.localScale.y * 0.8f, this.transform.localScale.z * 0.8f);
			scaleFlag1 = false;
		}else if(scaleFlag2 == true){
			this.transform.localScale = new Vector3(this.transform.localScale.x * 0.8f, this.transform.localScale.y * 0.8f, this.transform.localScale.z * 0.8f);
			scaleFlag2 = false;
		}else if(scaleFlag3 == true){
			this.transform.localScale = new Vector3(this.transform.localScale.x * 0.8f, this.transform.localScale.y * 0.8f, this.transform.localScale.z * 0.8f);
			scaleFlag3 = false;
		}else if(scaleFlag4 == true){
			this.transform.localScale = new Vector3(this.transform.localScale.x * 0.8f, this.transform.localScale.y * 0.8f, this.transform.localScale.z * 0.8f);
			scaleFlag4 = false;
		}else if(scaleFlag5 == true){
			this.transform.localScale = new Vector3(this.transform.localScale.x * 0.8f, this.transform.localScale.y * 0.8f, this.transform.localScale.z * 0.8f);
			scaleFlag5 = false;
		}
	}
}
