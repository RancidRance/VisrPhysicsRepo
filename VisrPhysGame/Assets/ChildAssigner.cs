using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VertexUnityPlayer;

public class ChildAssigner : MonoBehaviour {


    private float nextActionTime = 0.0f;
    public float period = 0.5f;


    // Use this for initialization
    void Start() {







    }

    // Update is called once per frame
    void Update() {



        if (Time.time > nextActionTime)
        {
            nextActionTime += period;



            GameObject[] allObjects = FindObjectsOfType<GameObject>();

            foreach (GameObject allObj in allObjects)
            {
                if (allObj.tag == "Untagged" && allObj.GetComponent<NodeLink>() == true)
                {




                    allObj.AddComponent<MeshCollider>();
                    if (!gameObject.GetComponent<exclusionList>().exclusionListCheck(allObj.GetComponent<NodeLink>().Id))
                    {
                        allObj.AddComponent<Rigidbody>();
                        allObj.GetComponent<Rigidbody>().isKinematic = true;
                        allObj.tag = "SceneLinkMoveableObject";
                    }
                    else
                    {
                        allObj.tag = ("SceneLinkStaticObject");
                    }
                }

            }
        }

        GameObject[] moveableObjects = GameObject.FindGameObjectsWithTag("SceneLinkMoveableObject");
        if (gameObject.GetComponent<HostChecker>().getAmIHost()==true) {
            foreach (GameObject objects in moveableObjects)
            {
                if (objects.GetComponent<amIHeld>().getAmIHeld()==false) {
                    objects.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
        }
        else
        {
            foreach (GameObject objects in moveableObjects)
            {
                objects.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }

    




}


