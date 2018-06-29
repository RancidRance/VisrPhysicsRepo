using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amIHeld : MonoBehaviour {
    public bool bAmIHeld = false;
	
    public bool getAmIHeld()
    {
        return bAmIHeld;
    }
    public void setAmIHeld(bool held)
    {
        bAmIHeld = held;
    }
}
