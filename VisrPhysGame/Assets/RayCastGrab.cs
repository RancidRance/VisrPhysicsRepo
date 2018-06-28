using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VertexUnityPlayer;

public class RayCastGrab : MonoBehaviour {

    public GameObject playerHead;
    RaycastHit hit;
    public int layerMask = -1;
    GameObject ParentNodeLink;
    
    public Transform rayCastGrab()
    {
        
        if (Physics.Raycast(playerHead.transform.position, playerHead.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {

            print(hit.transform.name);

            if (hit.transform.tag == "SceneLinkMoveableObject")
            {
                print("object grabbed: " + hit.transform.name);



                //   ParentNodeLink = getParent(hit.transform.gameObject);

                var nodeLink = hit.transform.gameObject.GetComponent<NodeLink>();

                gameObject.GetComponent<TogglePhysics>().toggleOff(nodeLink.transform.gameObject);

                return hit.transform;

               

               // return ParentNodeLink.transform;
            }
        }
       
            
            print("object not grabbed");
            return null;
        
    }
    private void Update()
    {
        Debug.DrawRay(playerHead.transform.position, playerHead.transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
    }


   GameObject getParent(GameObject child)
    {
        GameObject parent;

        parent = child.transform.parent.gameObject;

       var temp = parent.GetComponent<NodeLink>();

        if (temp == null)
        {
           var recurrsion = getParent(parent);

            return recurrsion;
        }

        return parent;
    }

}
