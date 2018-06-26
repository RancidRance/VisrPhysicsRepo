using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public GameObject player;
    public int movementSpeed;
    public int rotateSpeed;
    public Camera playerCamera;

    // Use this for initialization
    void Start () {
       playerCamera = gameObject.GetComponentInChildren(typeof(Camera)) as Camera;
    }
	
	// Update is called once per frame
	void Update () {
		
        

	}


   public void MoveForward ()
    {
        player.transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }

   public void MoveBack()
    {
        player.transform.position -= transform.forward * Time.deltaTime * movementSpeed;
    }

   public void TurnLeft()
    {
        player.transform.Rotate(-Vector3.up * Time.deltaTime * rotateSpeed);
    }

   public void TurnRight()
    {
        player.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
    }

   public void MoveCameraXLeft()
    {
        playerCamera.transform.Rotate(-Vector3.up * Time.deltaTime * rotateSpeed);
    }

   public void MoveCameraXRight()
    {
        playerCamera.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
    }

   public void MoveCameraYUp()
    {
        playerCamera.transform.Rotate(-Vector3.left * Time.deltaTime * rotateSpeed);
    }

   public void MoveCameraYDown()
    {
        playerCamera.transform.Rotate(Vector3.left * Time.deltaTime * rotateSpeed);
    }




}
