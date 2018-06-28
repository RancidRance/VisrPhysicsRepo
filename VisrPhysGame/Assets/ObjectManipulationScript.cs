using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectManipulationScript : MonoBehaviour {

    private Transform selectedObjectLock=null;
    bool followCamera=false;
    public GameObject CameraChild;

   

    public void rotateX(Transform selectedObject,float angle)
    {

        selectedObject.Rotate(Vector3.right*Time.deltaTime*angle);
       

    }
    public void rotateY(Transform selectedObject, float angle)
    {
        selectedObject.Rotate(Vector3.up * Time.deltaTime * angle);
        
    }
    public void rotateZ(Transform selectedObject, float angle)
    {
        selectedObject.Rotate(Vector3.forward * Time.deltaTime*angle);
        
    }
    public void translateX(Transform selectedObject, float step)
    {
        selectedObject.transform.Translate(Vector3.forward * Time.deltaTime * step, Space.World);

    }
    public void translateY(Transform selectedObject, float step)
    {
        selectedObject.transform.Translate(Vector3.right * Time.deltaTime * step, Space.World);
        
    }
    public void translateZ(Transform selectedObject, float step)
    {
        selectedObject.transform.Translate(Vector3.down * Time.deltaTime * step, Space.World);
        
    }
    public void scale(Transform selectedObject, float step)
    {
        selectedObject.transform.localScale += new Vector3(step, step, step);
        
    }
    public void lockObjectToCamera(Transform selectedObject)
    {
         Vector3 position = selectedObject.position;
         CameraChild.transform.position = position;
        selectedObjectLock = selectedObject;
        followCamera = true;

    }
    public void unlockObjectToCamera(Transform selectedObject)
    {
        selectedObjectLock=null;
        followCamera = false;
    }
    public float speed = 5;
    void Update()
    {
        if (followCamera)
        {
            float step = speed * Time.deltaTime;
            selectedObjectLock.transform.position = CameraChild.transform.position;//Vector3.MoveTowards(selectedObjectLock.transform.position, CameraChild.transform.position, step);
            selectedObjectLock.transform.rotation = CameraChild.transform.rotation;
        }
    }
}
