using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour {




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetAxisRaw("PlayerForwardBack") < 0.3)
        {
            gameObject.GetComponent<PlayerMovement>().MoveForward();
            print("Forward");
        }

        if (Input.GetAxisRaw("PlayerForwardBack") > -0.3)
        {
            gameObject.GetComponent<PlayerMovement>().MoveBack();
        }

        if (Input.GetAxisRaw("PlayerTurn") > 0.3)
        {
            gameObject.GetComponent<PlayerMovement>().TurnRight();
        }

        if (Input.GetAxisRaw("PlayerTurn") < -0.3)
        {
            gameObject.GetComponent<PlayerMovement>().TurnLeft();
        }

      //  if (Input.GetAxisRaw("CameraX") > 0.3)
      //  {
    //        gameObject.GetComponent<PlayerMovement>().MoveCameraXRight();
    //    }

    //    if (Input.GetAxisRaw("CameraX") < -0.3)
   //     {
   //         gameObject.GetComponent<PlayerMovement>().MoveCameraXLeft();
  //      }

        if (Input.GetAxisRaw("CameraY") > 0.3)
        {
            gameObject.GetComponent<PlayerMovement>().MoveCameraYUp();
        }

        if (Input.GetAxisRaw("CameraY") < -0.3)
        {
            gameObject.GetComponent<PlayerMovement>().MoveCameraYDown();
        }

        if (Input.GetButtonDown("Select") == true)
        {

        }

        if (Input.GetButtonDown("Deselect") == true)
        {

        }

        if (Input.GetButtonDown("ChangeModeForward") == true)
        {

        }

        if (Input.GetButtonDown("ChangeModeBack") == true)
        {

        }

        if (Input.GetAxisRaw("Increase") > 0.3)
        {

        }

        if (Input.GetAxisRaw("Decrease") > 0.3)
        {

        }


    }
}
