using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour {
    public Transform target;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 15, -20));
        Vector3 targetRotation = target.TransformDirection(new Quaternion(0, 0, 0. 0));

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, ref velocity, smoothTime);

    }
}
