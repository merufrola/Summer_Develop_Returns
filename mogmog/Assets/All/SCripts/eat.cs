using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class eat : MonoBehaviour {

public GameObject HMD ;
public GameObject Food;
Vector3 pos;


[SerializeField]
public GameObject usagi;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void Update () {
		//フードセンサの位置をHMDのカメラ位置と連動させる
		pos = InputTracking.GetLocalPosition(XRNode.CenterEye);
			transform.position = new Vector3(pos.x,pos.y-2.5f,pos.z-1.2f);
			// var trackedObject = GetComponent<SteamVR_TrackedObject>();
			//var device = SteamVR_Controller.Input((int)trackedObject.index);

			if (statemanager.Timeflag == 1){
				//device.TriggerHapticPulse(1000);
				Debug.Log("test");
			//Invoke("Dead",2);
		}

	}

	void OnTriggerEnter (Collider col) {

//センサに食べ物が当たった時の処理
	if(ContollerGrabObject.GrabFlag == true){
		switch(col.gameObject.tag){

			case "hare":
					col.gameObject.SendMessage("damage");
			    statemanager.point = statemanager.point + 5;
				break;
			case "fox" :
				col.gameObject.SendMessage("damage");
			statemanager.point = statemanager.point + 10;
			break;
			case "wolf" :
				col.gameObject.SendMessage("damage");
			statemanager.point = statemanager.point + 20;
			break;
			case "bear" :
				col.gameObject.SendMessage("damage");
			statemanager.point = statemanager.point + 700;
			break;
			case "food" :
			col.gameObject.SendMessage("damage");
			statemanager.point = statemanager.point + 1;
			break;

		}
	}
	if(ContollerGrabObject.GrabFlag == false){
		switch(col.gameObject.tag){
		case "hare":
		case "fox" :
		case "wolf" :
		case "bear" :



		// m_instance = m_shaker.StartShake(1,1,0.1f);
		// m_instance.DeleteOnInactive = false;

		//Time.timeScale = 0f;
		statemanager.Timeflag = 1;
		SteamVR_Fade.Start(Color.black,0f);
		Debug.Log("deaddddd");
			Invoke("Dead",2);

		break;
		}

	}

	}

	void Dead(){
		Debug.Log("dead");
		SceneManager.LoadScene("FinishScene");

	}
}
