using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectManipulationScript : MonoBehaviour {


   

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
}
