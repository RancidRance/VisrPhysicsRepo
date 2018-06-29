using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VertexUnityPlayer;

public class HostChecker : MonoBehaviour {

    // Use this for initialization
    GameObject controlObject;
    float nextActionTime = 0.0f;
    float period = 0.5f;


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       

        if (Time.time > nextActionTime)
        {

            nextActionTime += period;

            controlObject = GameObject.FindGameObjectWithTag("SceneLinkMoveableObject");


            controlObject.GetComponent<AssignPhysicTo>().HostChecker();
          





        }

    }
}
