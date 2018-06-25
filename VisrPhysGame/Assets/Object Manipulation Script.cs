using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManipulationScript : MonoBehaviour {

	void rotateX(Transform gameObject,int angle)
    {
        gameObject.Rotate(Vector3.right*Time.deltaTime*angle);
    }
    void rotateY(Transform gameObject, int angle)
    {
        gameObject.Rotate(Vector3.up * Time.deltaTime * angle);
    }
    void rotateZ(Transform gameObject, int angle)
    {
        gameObject.Rotate(0, 0, Time.deltaTime*angle);
    }
    void translateX(Transform gameobject,int step)
    {
        gameObject.transform.Translate(Vector3.forward*Time.deltaTime*step);
    }
}
