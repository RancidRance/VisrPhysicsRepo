using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEditorScript : MonoBehaviour {

    public Image SourceImage;
    public Sprite scale, rotate, translate;
    public Text manipulationAxis;

    // Use this for initialization
    private void Start()
    {
        manipulationAxis.text = "";
        SourceImage = gameObject.GetComponent<Image>();
        SourceImage.sprite = translate;
    }

    public void setManipulationToRotation()
    {
        SourceImage.sprite = rotate;
    }

    public void setManipulationToTranslation()
    {
        SourceImage.sprite = translate;
    }

    public void setManipulationToScaling()
    {
        SourceImage.sprite = scale;
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
