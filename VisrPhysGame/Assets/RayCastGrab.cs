using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastGrab : MonoBehaviour {

    public Camera playerHead;
    RaycastHit hit;
    public int layerMask = 2;
    
    Transform rayCastGrab()
    {
        if(Physics.Raycast(playerHead.transform.position,playerHead.transform.TransformDirection(Vector3.forward),out hit, Mathf.Infinity, layerMask))
        {
            return hit.transform;
        }
        return null;
    }
}
