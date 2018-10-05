using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class eat : MonoBehaviour {

public GameObject HMD ;
public GameObject Food;
Vector3 pos;

private AudioSource eatSound1;
private AudioSource breakSound;
public AudioSource BGM;

[SerializeField]
public GameObject usagi;

	// Use this for initialization
	void Start () {

		AudioSource[] audiosource = GetComponents<AudioSource>();
		eatSound1 = audiosource[0];
		breakSound = audiosource[1];
		BGM = audiosource[2];


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
Debug.Log(col.gameObject.tag);

switch(col.gameObject.tag){

case "hare":

	if(statemanager.haregrab == true ){
					col.gameObject.SendMessage("damage");
			    statemanager.point = statemanager.point + 5;
				eatSound1.PlayOneShot(eatSound1.clip);
				statemanager.haregrab = false;
				ContollerGrabObject.objectName = null;
break;
			}


			if(statemanager.haregrab == false){
				statemanager.Timeflag = 1;
				BGM.Stop();
				SteamVR_Fade.Start(Color.black,0f);
				Debug.Log("deaddddd "+ "hare");
					breakSound.PlayOneShot(breakSound.clip);
					Invoke("Dead",2);
break;
					}
					break;


case "fox":

if(statemanager.foxgrab == true){
	Debug.Log("ok");
			col.gameObject.SendMessage("damage");
		statemanager.point = statemanager.point + 10;
eatSound1.PlayOneShot(eatSound1.clip);
statemanager.foxgrab = false;
ContollerGrabObject.objectName = null;
break;
	}

if(statemanager.foxgrab == false){
	statemanager.Timeflag = 1;
	BGM.Stop();
	SteamVR_Fade.Start(Color.black,0f);
	Debug.Log("deaddddd "+ "fox");
		breakSound.PlayOneShot(breakSound.clip);
		Invoke("Dead",2);
		break;
}
break;

case "wolf":

if(statemanager.wolfgrab == true){
			col.gameObject.SendMessage("damage");
		statemanager.point = statemanager.point + 20;
eatSound1.PlayOneShot(eatSound1.clip);
statemanager.wolfgrab = false;
ContollerGrabObject.objectName = null;
break;
	}


	if(statemanager.wolfgrab == false){
		statemanager.Timeflag = 1;
		BGM.Stop();
		SteamVR_Fade.Start(Color.black,0f);
		Debug.Log("deaddddd "+ "wolf");
			breakSound.PlayOneShot(breakSound.clip);
			Invoke("Dead",2);
			break;

		}
break;

case "bear":
if(statemanager.beargrab == true){
			col.gameObject.SendMessage("damage");
		statemanager.point = statemanager.point + 700;
		eatSound1.PlayOneShot(eatSound1.clip);
		statemanager.beargrab = false;
		ContollerGrabObject.objectName = null;
		break;

	}

if(statemanager.beargrab == false){
	statemanager.Timeflag = 1;
	BGM.Stop();
	SteamVR_Fade.Start(Color.black,0f);
	Debug.Log("deaddddd "+ "bear");
		breakSound.PlayOneShot(breakSound.clip);
		Invoke("Dead",2);
break;
	}
break;

case "food":
if(statemanager.foodgrab == true){
		col.gameObject.SendMessage("damage");
		statemanager.point = statemanager.point + 1;
		eatSound1.PlayOneShot(eatSound1.clip);
		statemanager.foodgrab = false;
		ContollerGrabObject.objectName = null;
		break;
	}

break;

}



		}





	void Dead(){
		int nowtop = PlayerPrefs.GetInt("HighScore",0);
		Debug.Log("dead");
		if(nowtop<statemanager.point){
		PlayerPrefs.SetInt("HighScore", statemanager.point);
}
		SceneManager.LoadScene("FinishScene");

	}
}
