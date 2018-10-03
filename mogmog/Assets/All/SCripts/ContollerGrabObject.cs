using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContollerGrabObject : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;

    private GameObject collidingObject;

    private GameObject objectInHand;

    public static bool GrabFlag = false;

    public static string objectName;

    public static int state;



    //public bool canGrab = false;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    private void SetCollidingObject(Collider col)
    {
        if (collidingObject || !col.GetComponent<Rigidbody>())
        {
            return;
        }
        collidingObject = col.gameObject;
    }

    public void OnTriggerEnter(Collider other)
    {
        SetCollidingObject(other);
        if(other.gameObject.tag == "wolf"){
            objectName = "wolf";
        }else if(other.gameObject.tag == "bear"){
            objectName = "bear";
        }else if(other.gameObject.tag == "boar"){
            objectName = "boar";
        }else if(other.gameObject.tag == "deer"){
            objectName = "deer";
        }else if(other.gameObject.tag == "hare"){
            objectName = "hare";
        }else if(other.gameObject.tag == "fox"){
            objectName = "fox";
        }

    }

    public void OnTriggerStay(Collider other)
    {
        SetCollidingObject(other);
        if(other.gameObject.tag == "wolf"){
            objectName = "wolf";
        }else if(other.gameObject.tag == "bear"){
            objectName = "bear";
        }else if(other.gameObject.tag == "hare"){
            objectName = "hare";
        }else if(other.gameObject.tag == "fox"){
            objectName = "fox";
        }else if(other.gameObject.tag == "food"){
            objectName = "food";
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (!collidingObject)
        {
            return;
        }

        collidingObject = null;
        objectName = null;
    }

    private void GrabObject()
    {
        objectInHand = collidingObject;
        collidingObject = null;
        var joint = AddFixedJoint();
        joint.connectedBody = objectInHand.GetComponent<Rigidbody>();
    }

    private FixedJoint AddFixedJoint()
    {
        FixedJoint fx = gameObject.AddComponent<FixedJoint>();
        fx.breakForce = 20000;
        fx.breakTorque = 20000;
        return fx;
    }

    private void ReleaseObject()
    {
        if (GetComponent<FixedJoint>())
        {
            GetComponent<FixedJoint>().connectedBody = null;
            Destroy(GetComponent<FixedJoint>());

            objectInHand.GetComponent<Rigidbody>().velocity = Controller.velocity;
            objectInHand.GetComponent<Rigidbody>().angularVelocity = Controller.angularVelocity;
        }

        objectInHand = null;
    }

    void Update()
    {
        if (Controller.GetHairTriggerDown())
        {
            if (collidingObject)
            {
                if(objectName == "wolf" && statemanager.state <= 3){
                    GrabFlag = true;
                    GrabObject();
                }else if(objectName == "bear" && statemanager.state <= 4){
                    GrabFlag = true;
                    GrabObject();
                }else if(objectName == "hare" && statemanager.state <= 1){
                    GrabFlag = true;
                    GrabObject();
                }else if(objectName == "fox" && statemanager.state <= 2){
                    GrabFlag = true;
                    GrabObject();
                }else if(objectName == "food" && statemanager.state >= 0){
                    GrabFlag = true;
                    GrabObject();
                }

            }
        }

        if (Controller.GetHairTriggerUp())
        {
            if (objectInHand)
            {
                GrabFlag = false;
                ReleaseObject();
            }
        }
    }
    //
    // void Grab(){
    //
    //     if (Controller.GetHairTriggerDown())
    //     {
    //         if (collidingObject)
    //         {
    //             GrabObject();
    //             // switch(collidingObject.transform.tag){
    //             //     case "food":
    //             //         GrabObject();
    //             //         break;
    //             // case "hare" :
    //             //     if(statemanager.statemanager.statemanager.state>0){
    //             //         GrabObject();
    //             //     }
    //             // break;
    //             // case "fox" :
    //             // if(statemanager.statemanager.statemanager.state>1){
    //             //     GrabObject();
    //             // }
    //             // break;
    //             // case "wolf" :
    //             // if(statemanager.statemanager.statemanager.state>2){
    //             //     GrabObject();
    //             // }
    //             // break;
    //             // case "bear" :
    //             // if(statemanager.statemanager.statemanager.state>3){
    //             //     GrabObject();
    //             // }
    //             // break;
    //             // if(statemanager.statemanager.statemanager.state>4){
    //             //     GrabObject();
    //             // }
    //             // break;
    //             // case "human" :
    //             // if(statemanager.statemanager.statemanager.state>5){
    //             //     GrabObject();
    //             // }
    //             // break;
    //     //    }
    //
    //
    //         }
    //     }
    // }
}
