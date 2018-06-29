using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignPlayerAvatars : MonoBehaviour {


     float nextActionTime = 0.0f;
     float period = 0.5f;
    public GameObject PlayerAvatar;
    


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;


            GameObject viewPoints = GameObject.Find("Viewpoints");

            Transform[] children = viewPoints.GetComponentsInChildren<Transform>();
            foreach (Transform child in children)
            {
                if (child.transform.childCount < 1 && child.name != "TempAvatar(Clone)")
                {
                    Instantiate(PlayerAvatar, child.transform);
                }
          
            }

        }
   }
}
