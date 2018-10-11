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
		// if(ContollerGrabObject.GrabFlag == true){
		// 	this.Text.text = "true";
		// }
		// else{
		// 	this.Text.text = "false";
		// }
	 this.Text.text = ContollerGrabObject.testName;
	}

}
