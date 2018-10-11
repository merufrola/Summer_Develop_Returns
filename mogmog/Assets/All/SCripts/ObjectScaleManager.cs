using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaleManager : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		switch(this.transform.tag){

			case "hare":
				switch(statemanager.state){
					case 0:
					this.transform.localScale = new Vector3(0.4f,0.4f,0.4f);
					break;
					case 1:
					this.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
					break;
					case 2:
					this.transform.localScale = new Vector3(0.25f,0.25f,0.25f);
					break;
					case 3:
					this.transform.localScale = new Vector3(0.2f,0.2f,0.2f);
					break;
					case 4:
					this.transform.localScale = new Vector3(0.15f,0.15f,0.15f);
					break;


				}
break;

			case "fox":
			switch(statemanager.state){
				case 0:
				this.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
				break;
				case 1:
				this.transform.localScale = new Vector3(0.4f,0.4f,0.4f);
				break;
				case 2:
				this.transform.localScale = new Vector3(0.2f,0.2f,0.2f);
				break;
				case 3:
				this.transform.localScale = new Vector3(0.15f,0.15f,0.15f);
				break;
				case 4:
				this.transform.localScale = new Vector3(0.1f,0.1f,0.1f);
				break;


			}
break;
			case "wolf":
			switch(statemanager.state){
				case 0:
				this.transform.localScale = new Vector3(0.4f,0.4f,0.4f);
				break;
				case 1:
				this.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
				break;
				case 2:
				this.transform.localScale = new Vector3(0.25f,0.25f,0.25f);
				break;
				case 3:
				this.transform.localScale = new Vector3(0.2f,0.2f,0.2f);
				break;
				case 4:
				this.transform.localScale = new Vector3(0.18f,0.18f,0.18f);
				break;


			}
break;
			case "bear":
			switch(statemanager.state){
				case 0:
				this.transform.localScale = new Vector3(0.6f,0.6f,0.6f);
				break;
				case 1:
				this.transform.localScale = new Vector3(0.55f,0.55f,0.55f);
				break;
				case 2:
				this.transform.localScale = new Vector3(0.45f,0.45f,0.45f);
				break;
				case 3:
				this.transform.localScale = new Vector3(0.35f,0.35f,0.35f);
				break;
				case 4:
				this.transform.localScale = new Vector3(0.25f,0.25f,0.25f);
				break;


			}
break;

break;


		}













		// if(statemanager.state == 0){
		// 	scaleFlag0 = true;
		// }else if(statemanager.state == 1){
		//
		// 	scaleFlag1 = true;
		// }else if(statemanager.state == 2){
		//
		// 	scaleFlag2 = true;
		// }else if(statemanager.state == 3){
		//
		// 	scaleFlag3 = true;
		// }else if(statemanager.state == 4){
		//
		// 	scaleFlag4 = true;
		// }else if(statemanager.state == 5 && scaleFlag3 == true){
		//
		// 	scaleFlag5 = true;
		// }
		//
		// if(scaleFlag0 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 1.0f, this.transform.localScale.y * 1.0f, this.transform.localScale.z * 1.0f);
		// 	scaleFlag0 = false;
		// }else if(scaleFlag1 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 0.8f, this.transform.localScale.y * 0.8f, this.transform.localScale.z * 0.8f);
		// 	scaleFlag1 = false;
		// }else if(scaleFlag2 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 0.8f, this.transform.localScale.y * 0.8f, this.transform.localScale.z * 0.8f);
		// 	scaleFlag2 = false;
		// }else if(scaleFlag3 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 0.8f, this.transform.localScale.y * 0.8f, this.transform.localScale.z * 0.8f);
		// 	scaleFlag3 = false;
		// }else if(scaleFlag4 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 0.8f, this.transform.localScale.y * 0.8f, this.transform.localScale.z * 0.8f);
		// 	scaleFlag4 = false;
		// }else if(scaleFlag5 == true){
		// 	this.transform.localScale = new Vector3(this.transform.localScale.x * 0.8f, this.transform.localScale.y * 0.8f, this.transform.localScale.z * 0.8f);
		// 	scaleFlag5 = false;
		// }
	}
}
