using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEditorScript : MonoBehaviour {

    public Image SourceImage;
    public Sprite scale, rotate, translate;
    public Text manipulationAxis, outlineText;

    // Use this for initialization
    private void Start()
    {
      
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
        manipulationAxis.text = "Uniform Scaling";
        outlineText.text = "Uniform Scaling";
    }

    public void setAxisToX()
    {
        manipulationAxis.text = "Manipulation Axis: X";
        outlineText.text = "Manipulation Axis: X";
  
    }

    public void setAxisToY()
    {
        manipulationAxis.text = "Manipulation Axis: Y";
        outlineText.text = "Manipulation Axis: Y";
    }

    public void setAxisToZ()
    {
        manipulationAxis.text = "Manipulation Axis: Z";
        outlineText.text = "Manipulation Axis: Z";
    }
}
