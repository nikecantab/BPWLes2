using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {

    private AudioSource windSource;

	// Use this for initialization
	void Start () {
        //casting a var: cast to another type(AudioSource)
        windSource = (AudioSource)GetComponent(typeof(AudioSource));
	}

    void OnTriggerEnter(Collider other)
    {
        windSource.Play();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
            windSource.Play();
    }
}
