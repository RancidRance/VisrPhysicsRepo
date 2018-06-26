using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManipulationScript : MonoBehaviour {

	void rotateX(Transform gameObject,float angle)
    {
        gameObject.Rotate(Vector3.right*Time.deltaTime*angle);
    }
    void rotateY(Transform gameObject, float angle)
    {
        gameObject.Rotate(Vector3.up * Time.deltaTime * angle);
    }
    void rotateZ(Transform gameObject, float angle)
    {
        gameObject.Rotate(Vector3.forward * Time.deltaTime*angle);
    }
    void translateX(Transform gameobject,float step)
    {
        gameObject.transform.Translate(Vector3.forward*Time.deltaTime*step);
    }
    void translateY(Transform gameobject, float step)
    {
        gameObject.transform.Translate(Vector3.right * Time.deltaTime * step);
    }
    void translateZ(Transform gameobject, float step)
    {
        gameObject.transform.Translate(Vector3.down * Time.deltaTime * step);
    }
    void scale(Transform gameobject,float step)
    {
        gameObject.transform.localScale.Scale(new Vector3(1,1,1)*Time.deltaTime * step);
    }
}
