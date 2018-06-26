using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEditorScript : MonoBehaviour {

    public Text manipulationType;
    public Text manipulationAxis;

    // Use this for initialization
    private void Start()
    {
        manipulationType.text = "";
        manipulationAxis.text = "";
    }

    public void setManipulationToRotation()
    {
        manipulationType.text = "Manipulation Type: Rotation";
    }

    public void setManipulationToTranslation()
    {
        manipulationType.text = "Manipulation Type: Translation";
    }

    public void setManipulationToScaling()
    {
        manipulationType.text = "Manipulation Type: Scaling";
    }

    public void setAxisToX()
    {
        manipulationAxis.text = "Manipulation Axis: X";
    }

    public void setAxisToY()
    {
        manipulationAxis.text = "Manipulation Axis: Y";
    }

    public void setAxisToZ()
    {
        manipulationAxis.text = "Manipulation Axis: Z";
    }
}
