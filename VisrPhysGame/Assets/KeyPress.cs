using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPress : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            Debug.Log("something has been pressed");
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
	}
}
