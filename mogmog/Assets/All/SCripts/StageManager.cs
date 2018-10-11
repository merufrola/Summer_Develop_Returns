using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour {

	// Use this for initializationca
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		switch(statemanager.state){
			case 0:
			this.transform.localScale = new Vector3(0.7f,0.7f,0.7f);
			break;

			case 1:
			this.transform.localScale = new Vector3(0.6f,0.6f,0.6f);
			break;

			case 2:
			this.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
			break;

			case 3:
			this.transform.localScale = new Vector3(0.4f,0.4f,0.4f);
			
			break;

			case 4:
			this.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
			break;

		}
	}
}
