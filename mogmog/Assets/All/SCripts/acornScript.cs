using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acornScript : MonoBehaviour {

	public float destroyTime;

	// Use this for initialization
	void Start () {
		Invoke("damage",destroyTime);
	}

	// Update is called once per frame
	void Update () {

	}

	void damage(){
		Destroy(this.gameObject);
	}
}
