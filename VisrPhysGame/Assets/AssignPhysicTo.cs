using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VertexUnityPlayer;

public class AssignPhysicTo : MonoBehaviour {

    public bool amIHost = false;
    bool isThereAHost = false;
    float myNumber;
    float nextActionTime = 0.0f;
    float period = 0.5f;
    // Use this for initialization
    void Start () {
        

    }

    private void Update()
    {

        
        HostCall();

        if (Time.time > nextActionTime)
        {
            nextActionTime += period;


            


            if (isThereAHost == false)
            {

                AssignHostRandom();
            }
            else
            {
                isThereAHost = false;
            }
        }
        string sendNumber = myNumber.ToString();
        gameObject.GetComponent<NodeLink>().Fire("randomDecider", sendNumber);
    }

    public void AssignHostRandom()
    {
        amIHost = true;
        randomGen();
        //string sendNumber = myNumber.ToString();
        //gameObject.GetComponent<NodeLink>().Fire("randomDecider", sendNumber);
    }

    public void AssignHost()
    {

    }



    public void givePhysicsTo(GameObject selectedObject)
    {
        var nodeLink = selectedObject.GetComponent<NodeLink>();

        //SendMessage("print", "Physics Given to: " + VertexAuthentication.Instance.AuthProvider.GetUserId());
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

    public void playerIDChecker(string ID)
    {
        if(ID == VertexAuthentication.Instance.AuthProvider.GetUserId()) //== player's ID.ToString()
        {
            print("enable physics");
            enablePhysics();
        }
        else
        {
            disablePhysics();
        }
    }

    public void randomGen()
    {
        myNumber = Random.Range(0f, 1000.0f);
    }

    public void randomDecider(string number)
    {
        float otherPersonNumber = float.Parse(number);
       

        if(myNumber < otherPersonNumber)
        {
            amIHost = false;
        }
    }

    public void HostResponse()
    {
        if(amIHost == true)
        {
            gameObject.GetComponent<NodeLink>().Fire("HostRecieve", null);
        }
       
      
    }

    public void HostCall()
    {
        gameObject.GetComponent<NodeLink>().Fire("HostResponse", null);
    }

    public void HostRecieve()
    {
        isThereAHost = true;
    }
    public void objectSelectRequest(Transform objectSelected)
    {
        if (amIHost)
        {
            //check if host is holding
            gameObject.GetComponent<TogglePhysics>().toggleOff(objectSelected.transform.gameObject);
        }
        else
        {
            objectSelected.GetComponent<NodeLink>().Fire("objectSelectRequestRecieved", objectSelected);
            
        }
    }

    public void objectSelectRequestRecieved(Transform objectSelected)
    {
        if (amIHost)
        {
            //check if host is holding
            gameObject.GetComponent<TogglePhysics>().toggleOff(objectSelected.transform.gameObject);
        }
    }
    public void objectDeselectRequest(Transform objectSelected)
    {
        if (amIHost)
        {
            //disable kinematics
            gameObject.GetComponent<TogglePhysics>().toggleOn(objectSelected.transform.gameObject);
        }
        else
        {
            objectSelected.GetComponent<NodeLink>().Fire("objectDeselectRequestRecieved", objectSelected);
            //send message to host to disable kinematics 
        }
    }
    public void objectDeselectRequestRecieved(Transform objectSelected)
    {
        if (amIHost)
        {
            //disable kinematics
            gameObject.GetComponent<TogglePhysics>().toggleOn(objectSelected.transform.gameObject);
        }
    }
    public void objectThrowRequest(string objNameTransform)
    {


        if (amIHost)
        {
            //disable kinematics
        //    gameObject.GetComponent<TogglePhysics>().toggleOn(objectSelected.transform.gameObject);
        }
        else
        {

          //  objectSelected.GetComponent<NodeLink>().Fire("objectDeselectRequest", objectSelected);
            //send message to host to disable kinematics 
        }
    }



}
