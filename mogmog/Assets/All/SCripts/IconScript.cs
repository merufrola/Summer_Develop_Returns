using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconScript : MonoBehaviour {

public GameObject hareIcon;
public GameObject foxIcon;
public GameObject wolfIcon;
public GameObject bearIcon;


	// Use this for initialization
	void Start () {
hareIcon.SetActive(false);
foxIcon.SetActive(false);
wolfIcon.SetActive(false);
bearIcon.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
switch(statemanager.state){
	case 1:
	hareIcon.SetActive(true);
	break;
	case 2:
	foxIcon.SetActive(true);
		break;
	case 3:
	wolfIcon.SetActive(true);
		break;
	case 4:
	bearIcon.SetActive(true);
		break;


}



	}
}
