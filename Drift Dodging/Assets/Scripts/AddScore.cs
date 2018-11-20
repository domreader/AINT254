using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour {


    private bool isInCollider;
    public Text Score;
    private int Number;
    private int updatedNumber;



    // Use this for initialization
    void Start () {

        isInCollider = false;

        Number = 0;

        updatedNumber = 0;

    }

    private void OnTriggerEnter(Collider other)
    {

        isInCollider = true;


    }

    private void OnTriggerExit(Collider other)
    {

        isInCollider = false;

    }

    void Update()
    {
        if(isInCollider == true)
        {

            Number = (updatedNumber++);


        }

        Score.text = ("Score : " + Number);

    }


}
