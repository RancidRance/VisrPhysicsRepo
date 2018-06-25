using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastingScript : MonoBehaviour {
    public Camera playerHead;
    public int layerMask = 2;
    RaycastHit hit;
    Transform rayShoot()
    {
        if (Physics.Raycast(playerHead.transform.position,playerHead.transform.TransformDirection(Vector3.forward),out hit,Mathf.Infinity, layerMask))
        {
            return hit.transform;
        }
        else
        {
            return null;
        }
    }
}
