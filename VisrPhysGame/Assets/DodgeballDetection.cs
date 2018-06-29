using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeballDetection : MonoBehaviour {

    // Use this for initialization
    public AudioSource source;
    public AudioClip hitSound;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SceneLinkMoveableObject")
        {
            source.PlayOneShot(hitSound, 1);
        }
    }

}
