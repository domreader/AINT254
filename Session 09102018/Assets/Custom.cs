using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom : MonoBehaviour {

    private void OnGUI()
    {
        GUI.Label(new Rect(5, 5, 200, 30), "Horizontal Axis: ");
        GUI.Label(new Rect(150, 5, 200, 30), Input.GetAxis("Horizontal").ToString());

        GUI.Label(new Rect(5, 20, 200, 30), "Vertical Axis: ");
        GUI.Label(new Rect(150, 20, 200, 30), Input.GetAxis("Vertical").ToString());

    }
}
