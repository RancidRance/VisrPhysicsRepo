using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePointer : MonoBehaviour {
    GameObject pointer;
	// Update is called once per frame
	void Update () {
        pointer.transform.position = new Vector3(Screen.width / 2f, Screen.height / 2f, 0);
	}
}
