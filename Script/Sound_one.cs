using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_one : MonoBehaviour{
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource> ();
    }
	
	void OnCollisionEnter(Collision collision){  

if (collision.gameObject.name == "Cube") {

  audio.Play ();
   }
  }
 }
