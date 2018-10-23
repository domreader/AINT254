using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour {

    Collider exitCollider;

	// Use this for initialization
	void Start () {

       
	}

     void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Exit");
    }

    // Update is called once per frame
    void Update () {
		
       
	}
}
