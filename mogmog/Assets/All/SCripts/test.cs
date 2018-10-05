using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour {
public Text Text;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// if(statemanager.foodgrab){
		// 	this.Text.text = "1";
		// }
		// else{
		// 	this.Text.text = "0";
		// }
		this.Text.text = ContollerGrabObject.objectName;
	}

}
