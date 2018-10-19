using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformRoll : MonoBehaviour
{

    private Transform ball_Transform;

    [SerializeField]
    private int ballSpeed;

    // Use this for initialization
    void Start()
    {

        ball_Transform = transform;
    }

    private void slideAttack()
    {

        int rollX;
        int rollY;
        int rollZ;

        rollX = 5;
        rollY = 5;
        rollZ = 5;

        int speedOfRoll = ballSpeed * rollY;

        rollY = speedOfRoll;

        ball_Transform.position += new Vector3(rollX, rollY, rollZ);


    }


    // Update is called once per frame
    void Update()
    {

        slideAttack();

    }
}
