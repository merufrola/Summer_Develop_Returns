using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 1, 0));
	}
}
