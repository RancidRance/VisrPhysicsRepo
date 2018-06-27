using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(10f);
    }

	// Use this for initialization
	void Start () {
        SwitchScene();
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
	}
}
