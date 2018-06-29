using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowWhenSelected : MonoBehaviour {

    
    private void Update()
    {
        
            if (gameObject.GetComponent<amIHeld>().getAmIHeld() == true)
            {
                Transform[] children = gameObject.GetComponentsInChildren<Transform>();
                foreach (Transform child in children)
                {
                    if (child.name == "Primitive")
                    {
                        Renderer rend = child.GetComponent<Renderer>();
                        //Set the main Color of the Material to green
                         rend.material.shader = Shader.Find("_EmissionColor");

                        rend.material.SetColor("_EmissionColor", Color.blue);
                    }

                }
            }
        
    }
    
}
