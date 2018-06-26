using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastGrab : MonoBehaviour {

    public GameObject playerHead;
    RaycastHit hit;
    public int layerMask = -1;
    
    public Transform rayCastGrab()
    {
        
        if (Physics.Raycast(playerHead.transform.position, playerHead.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            print("object grabbed");
            if (hit.transform.tag!="RaycastIgnore") {
                return hit.transform;
            }
        }
       
            
            print("object not grabbed");
            return null;
        
    }
    private void Update()
    {
        Debug.DrawRay(playerHead.transform.position, playerHead.transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
    }
}
