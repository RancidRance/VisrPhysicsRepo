using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

    IEnumerator SwitchScene()
    {
        yield return new WaitForSecondsRealtime(10.0f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

	// Use this for initialization
	void Start () {
        
        StartCoroutine(SwitchScene());
	}
}
