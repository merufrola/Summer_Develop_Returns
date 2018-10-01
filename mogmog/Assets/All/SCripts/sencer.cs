using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EZCameraShake;
using UnityEngine.XR;

public class sencer : MonoBehaviour {
public GameObject head ;
Vector3 pos;
int flag = 0;

public CameraShaker m_shaker;
private CameraShakeInstance m_instance;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		pos = InputTracking.GetLocalPosition(XRNode.CenterEye);
		//pos.y -= 0.7f;
		transform.position = new Vector3(pos.x,pos.y-4.7f,pos.z);
if (Time.timeScale == 0){
	if(flag == 0){
	Debug.Log("2");
		// Invoker.InvokeDelayed(Dead,1);
		flag = 1;
	}
}

	}

	void OnTriggerEnter(Collider col){
		Debug.Log("b");

		switch(col.gameObject.tag){
		case "hare":
		case "fox" :
		case "wolf" :
		case "bear" :
		case "human" :


		// m_instance = m_shaker.StartShake(1,1,0.1f);
		// m_instance.DeleteOnInactive = false;

		Time.timeScale = 0f;



		break;
	}

	}

	void Dead(){
		Debug.Log("dead");
		SceneManager.LoadScene("FinishScene");
	}
}
