using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePhysics : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	public void toggleOff(GameObject selectedObject)
    {
        selectedObject.GetComponent<Rigidbody>().useGravity = false;
        selectedObject.GetComponent<Rigidbody>().isKinematic = true;
    }

   public void toggleOn(GameObject selectedObject)
    {
        selectedObject.GetComponent<Rigidbody>().useGravity = true;
        selectedObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
