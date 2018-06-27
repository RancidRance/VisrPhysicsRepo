using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{

    public GameObject playerCamera;
    Transform objectSelected = null;
    List<string> mode;
    int i = 0;
    public string selectedMode;
    public GameObject canvasObject;
    public bool freeMode=false;
    private float nextActionTime = 0.0f;
    public float period = 0.5f;
    public float rotatePower;
    public float tranPower;
    public float scalePower;
    // Use this for initialization
    void Start()
    {
        mode = new List<string> { "rotX", "rotY", "rotZ", "tranX", "tranY", "tranZ", "scale" };
        selectedMode = mode[0];

        canvasObject.GetComponentInChildren<TextEditorScript>().setManipulationToRotation();
        canvasObject.GetComponentInChildren<TextEditorScript>().setAxisToX();
   
    }

    // Update is called once per frame
    void Update()
    {

      



            if (Input.GetAxis("PlayerForwardBack") < 0.3)
        {
            gameObject.GetComponent<PlayerMovement>().MoveForward();

        }

        if (Input.GetAxis("PlayerForwardBack") > -0.3)
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

        if (Input.GetAxis("PlayerLeftRight") > 0.3)
        {
            gameObject.GetComponent<PlayerMovement>().MoveRight();
        }

        if (Input.GetAxis("PlayerLeftRight") < -0.3)
        {
            gameObject.GetComponent<PlayerMovement>().MoveLeft();
        }

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
            


            if (freeMode==true && objectSelected != null)
            {
                gameObject.GetComponent<TogglePhysics>().toggleOn(objectSelected.transform.gameObject);

                gameObject.GetComponent<ObjectManipulationScript>().unlockObjectToCamera(objectSelected);
                
            }
            objectSelected = null;
            objectSelected = gameObject.GetComponent<RayCastGrab>().rayCastGrab();
            if (freeMode == true && objectSelected != null)
            {
               

                gameObject.GetComponent<ObjectManipulationScript>().lockObjectToCamera(objectSelected, playerCamera);
            }

        }

        if (Input.GetButtonDown("Deselect") == true)
        {
            if (freeMode == true && objectSelected != null)
            {
                gameObject.GetComponent<TogglePhysics>().toggleOn(objectSelected.transform.gameObject);

                gameObject.GetComponent<ObjectManipulationScript>().unlockObjectToCamera(objectSelected);
                
            }
            objectSelected = null;
        }

        if (Input.GetButtonDown("ChangeModeBack") == true)
        {
            if (i < 6)
            {
                ++i;
            }
            else
            {
                i = 0;
            }
            selectedMode = mode[i];

            ChangeUI();
        }

        if (Input.GetButtonDown("ChangeModeForward") == true)
        {
            if (i > 0)
            {
                --i;
            }
            else
            {
                i = 6;
            }
            selectedMode = mode[i];

            ChangeUI();

        }


        if (Input.GetAxisRaw("Increase") > 0.3)
        {
            switch (selectedMode)
            {
                case "rotX":
                    gameObject.GetComponent<ObjectManipulationScript>().rotateX(objectSelected, rotatePower);

                    break;
                case "rotY":
                    gameObject.GetComponent<ObjectManipulationScript>().rotateY(objectSelected, rotatePower);

                    break;
                case "rotZ":
                    gameObject.GetComponent<ObjectManipulationScript>().rotateZ(objectSelected, rotatePower);

                    break;
                case "tranX":
                    gameObject.GetComponent<ObjectManipulationScript>().translateX(objectSelected, tranPower);

                    break;
                case "tranY":
                    gameObject.GetComponent<ObjectManipulationScript>().translateY(objectSelected, tranPower);

                    break;
                case "tranZ":
                    gameObject.GetComponent<ObjectManipulationScript>().translateZ(objectSelected, tranPower);

                    break;
                case "scale":
                    gameObject.GetComponent<ObjectManipulationScript>().scale(objectSelected, scalePower);

                    break;
                default:
                    break;

            }

        }

        if (Input.GetAxisRaw("Decrease") > 0.3)
        {
            switch (selectedMode)
            {
                case "rotX":
                    gameObject.GetComponent<ObjectManipulationScript>().rotateX(objectSelected, -(rotatePower));
                    break;
                case "rotY":
                    gameObject.GetComponent<ObjectManipulationScript>().rotateY(objectSelected, -(rotatePower));
                    break;
                case "rotZ":
                    gameObject.GetComponent<ObjectManipulationScript>().rotateZ(objectSelected, -(rotatePower));
                    break;
                case "tranX":
                    gameObject.GetComponent<ObjectManipulationScript>().translateX(objectSelected, -(tranPower));
                    break;
                case "tranY":
                    gameObject.GetComponent<ObjectManipulationScript>().translateY(objectSelected, -(tranPower));
                    break;
                case "tranZ":
                    gameObject.GetComponent<ObjectManipulationScript>().translateZ(objectSelected, -(tranPower));
                    break;
                case "scale":
                    if (objectSelected.localScale.x > 0.1f)
                    {
                        gameObject.GetComponent<ObjectManipulationScript>().scale(objectSelected, -(scalePower));
                    }
                    break;
                default:
                    break;
            }
        }


    }


    void ChangeUI()
    {

        switch (selectedMode)
        {
            case "rotX":

                canvasObject.GetComponentInChildren<TextEditorScript>().setManipulationToRotation();
                canvasObject.GetComponentInChildren<TextEditorScript>().setAxisToX();
                break;
            case "rotY":

                canvasObject.GetComponentInChildren<TextEditorScript>().setManipulationToRotation();
                canvasObject.GetComponentInChildren<TextEditorScript>().setAxisToY();
                break;
            case "rotZ":

                canvasObject.GetComponentInChildren<TextEditorScript>().setManipulationToRotation();
                canvasObject.GetComponentInChildren<TextEditorScript>().setAxisToZ();
                break;
            case "tranX":

                canvasObject.GetComponentInChildren<TextEditorScript>().setManipulationToTranslation();
                canvasObject.GetComponentInChildren<TextEditorScript>().setAxisToX();
                break;
            case "tranY":

                canvasObject.GetComponentInChildren<TextEditorScript>().setManipulationToTranslation();
                canvasObject.GetComponentInChildren<TextEditorScript>().setAxisToY();
                break;
            case "tranZ":

                canvasObject.GetComponentInChildren<TextEditorScript>().setManipulationToTranslation();
                canvasObject.GetComponentInChildren<TextEditorScript>().setAxisToZ();
                break;
            case "scale":

                canvasObject.GetComponentInChildren<TextEditorScript>().setManipulationToScaling();
                break;
            default:
                break;
        }



    }
}
    

