using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformMove : MonoBehaviour {

    private Transform ball_Transform;

    [SerializeField]
    private float ballSpeed;

    // Use this for initialization
    void Start()
    {

        ball_Transform = transform;
    }

    private void slideAttack()
    {

        
        float rollX;
        float rollY;
        float rollZ;

        rollX = 0.1f;
        rollY = 0.1f;
        rollZ = 0.1f;

        float speedOfRoll = rollX * ballSpeed;

        rollX = speedOfRoll;

        ball_Transform.position += new Vector3(rollX, rollY, rollZ);


    }


    // Update is called once per frame
    void Update()
    {

        slideAttack();

    }
}
