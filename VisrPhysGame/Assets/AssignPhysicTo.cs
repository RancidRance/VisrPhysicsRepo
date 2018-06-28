using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VertexUnityPlayer;

public class AssignPhysicTo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    void givePhysicsTo(GameObject selectedObject)
    {
        var nodeLink = selectedObject.GetComponent<NodeLink>();

        nodeLink.Fire("playerIDChecker", VertexAuthentication.Instance.AuthProvider.GetUserId());
    }


    void enablePhysics()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        foreach (GameObject allObj in allObjects)
        {
            if (allObj.tag == "SceneLinkMoveableObject")
            {
                allObj.GetComponent<Rigidbody>().isKinematic = false;
            }

          
        }
    }

    void disablePhysics()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        foreach (GameObject allObj in allObjects)
        {
            if (allObj.tag == "SceneLinkMoveableObject")
            {
                allObj.GetComponent<Rigidbody>().isKinematic = true;
            }


        }
    }

    void playerIDChecker(string ID)
    {
        if(ID == VertexAuthentication.Instance.AuthProvider.GetUserId()) //== player's ID.ToString()
        {
            enablePhysics();
        }
        else
        {
            disablePhysics();
        }
    }



}
