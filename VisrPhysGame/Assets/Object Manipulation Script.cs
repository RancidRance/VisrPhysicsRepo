using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManipulationScript : MonoBehaviour {
    public Text manipulationType;
    public Text manipulationAxis;

    private void Start()
    {
        manipulationType.text = "Manipulation Type: ";
        manipulationAxis.text = "Manipulation Axis: ";
    }

    void rotateX(Transform gameObject,float angle)
    {
        gameObject.Rotate(Vector3.right*Time.deltaTime*angle);
        manipulationType.text = "Manipulation Type: Rotation";
        manipulationAxis.text = "Manipulation Axis: X";

    }
    void rotateY(Transform gameObject, float angle)
    {
        gameObject.Rotate(Vector3.up * Time.deltaTime * angle);
        manipulationType.text = "Manipulation Type: Rotation";
        manipulationAxis.text = "Manipulation Axis: Y";
    }
    void rotateZ(Transform gameObject, float angle)
    {
        gameObject.Rotate(Vector3.forward * Time.deltaTime*angle);
        manipulationType.text = "Manipulation Type: Rotation";
        manipulationAxis.text = "Manipulation Axis: Z";
    }
    void translateX(Transform gameobject,float step)
    {
        gameObject.transform.Translate(Vector3.forward*Time.deltaTime*step);
        manipulationType.text = "Manipulation Type: Translation";
        manipulationAxis.text = "Manipulation Axis: X";
    }
    void translateY(Transform gameobject, float step)
    {
        gameObject.transform.Translate(Vector3.right * Time.deltaTime * step);
        manipulationType.text = "Manipulation Type: Translation";
        manipulationAxis.text = "Manipulation Axis: Y";
    }
    void translateZ(Transform gameobject, float step)
    {
        gameObject.transform.Translate(Vector3.down * Time.deltaTime * step);
        manipulationType.text = "Manipulation Type: Translation";
        manipulationAxis.text = "Manipulation Axis: Z";
    }
    void scale(Transform gameobject,float step)
    {
        gameObject.transform.localScale.Scale(new Vector3(1,1,1)*Time.deltaTime * step);
        manipulationType.text = "Manipulation Type: Scaling";
        manipulationAxis.text = "";
    }
}
