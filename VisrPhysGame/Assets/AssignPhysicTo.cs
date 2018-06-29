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
    int i = 0;
    GameObject gameEngine;
    // Use this for initialization
    void Start () {

        gameEngine = GameObject.Find("GameEngine");
    }

    private void Update()
    {

        amIHost = gameEngine.GetComponent<HostChecker>().getAmIHost();
      
        
        
    }

    public void HostChecker()
    {
        HostCall();
      





        if (isThereAHost == false)
        {

            AssignHostRandom();
        }
        else
        {
            isThereAHost = false;
        }
        string sendNumber = myNumber.ToString();
        gameObject.GetComponent<NodeLink>().Fire("randomDecider", sendNumber);
    }

    public void AssignHostRandom()
    {
        //amIHost = true;
        gameEngine.GetComponent<HostChecker>().setAmIHostTrue();
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
            //amIHost = false;
            gameEngine.GetComponent<HostChecker>().setAmIHostFalse();
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
    public void objectSelectRequest()
    {
        if (amIHost)
        {
            //check if host is holding
            gameObject.GetComponent<TogglePhysics>().toggleOff(gameObject.transform.gameObject);
        }
        else
        {
            gameObject.GetComponent<NodeLink>().Fire("objectSelectRequestRecieved", null);
            
        }
    }

    public void objectSelectRequestRecieved()
    {
        if (amIHost)
        {
            //check if host is holding
            gameObject.GetComponent<TogglePhysics>().toggleOff(gameObject.transform.gameObject);
        }
    }
    public void objectDeselectRequest()
    {
        if (amIHost)
        {
            //disable kinematics
            gameObject.GetComponent<TogglePhysics>().toggleOn(gameObject.transform.gameObject);
        }
        else
        {
            gameObject.GetComponent<NodeLink>().Fire("objectDeselectRequestRecieved",null);
            //send message to host to disable kinematics 
        }
    }
    public void objectDeselectRequestRecieved()
    {
        if (amIHost)
        {
            //disable kinematics
            gameObject.GetComponent<TogglePhysics>().toggleOn(gameObject.transform.gameObject);
        }
    }
    public void objectThrowRequest(Transform camera)
    {


        if (amIHost)
        {
         
            gameObject.GetComponent<TogglePhysics>().toggleOn(gameObject.transform.gameObject);
            gameObject.GetComponent<Rigidbody>().AddForce(camera.forward * 750);
        }
        else
        {
            
            gameObject.GetComponent<NodeLink>().Fire("objectThrowRequestRecieved", camera.forward.ToString());
           
        }
    }

    public void objectThrowRequestRecieved(string throwVector)
    {
        if (amIHost)
        {

            throwVector = throwVector.Replace("(", "");
            throwVector = throwVector.Replace(")", "");

            string[] vector = throwVector.Split(',');
         
            

            gameObject.GetComponent<TogglePhysics>().toggleOn(gameObject.transform.gameObject);
            gameObject.GetComponent<Rigidbody>().AddForce( new Vector3 (float.Parse(vector[0]), float.Parse(vector[1]), float.Parse(vector[2])) * 750);
        }
    }


}
