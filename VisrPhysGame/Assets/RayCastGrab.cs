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
            print("object grabbed");


           ParentNodeLink = getParent(hit.transform.gameObject);

            if (ParentNodeLink.transform.tag!="RaycastIgnore") {


               

                return ParentNodeLink.transform;
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
