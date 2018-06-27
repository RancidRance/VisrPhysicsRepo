using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignPhysicsTo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    void givePhysicsTo(GameObject selectedObject)
    {
       var nodeLink = selectedObject.FindNodeLink();
    }


    void enablePhysics()
    {

    }

    void disablePhysics()
    {

    }

    void playerIDChecker(string ID)
    {
        if(ID == ) //== player's ID.ToString()
        {
            enablePhysics();
        }
        else
        {
            disablePhysics();
        }
    }



}
