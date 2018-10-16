using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

    private Transform m_transform;

    [SerializeField]
    private AnimationCurve m_curve;

    private void Start()
    {
        m_transform = transform;
    }

    private void stopCurve()
    {

        float randomCurve = Random.Range(0.0f, 1.0f);

        float stepX = 0;
        float stepZ = 0;

        float randomMove = m_curve.Evaluate(randomCurve);

        if (randomMove < 0.25f)
        {

            stepX = -0.1f;

        }
        else if (randomMove < 0.5f)
        {

            stepX = 0.1f;

        }
        else if (randomMove < 0.75f)
        {

            stepZ = -0.1f;

        }
        else if (randomMove < 1.00f)
        {

            stepZ = 0.1f;

        }

        m_transform.position += new Vector3(stepX, 0.0f, stepZ);

    }

    private void Stop()
    {
        
        int randomMove = Random.Range(0, 4);

        float stepX = 0;
        float stepZ = 0;

        if(randomMove == 0)
        {

            stepX = -0.1f;
        
        }
        else if (randomMove == 1)
        {

            stepX = 0.1f;

        }
        else if (randomMove == 2)
        {

            stepZ = -0.1f;

        }
        else if (randomMove == 3)
        {

            stepZ = 0.1f;

        }

        m_transform.position += new Vector3(stepX, 0.0f, stepZ);

    }

    private void stopArray()
    {



        int[] elements = new int[5]; // Create array

        elements[0] = 0; // Elements
        elements[1] = 1;
        elements[2] = 2;
        elements[3] = 3;
        elements[4] = 0;

        int randomIndex = Random.Range(0, 5); // Random Number
        int randomMove = elements[randomIndex]; // Setting randomMove to same values and randomIndex

        float stepX = 0;
        float stepZ = 0;

        if(randomMove == 0) // If to move based on elements
        {

            stepX = -0.1f;
        
        }
        else if (randomMove == 1)
        {

            stepX = 0.1f;

        }
        else if (randomMove == 2)
        {

            stepZ = -0.1f;

        }
        else if (randomMove == 3)
        {

            stepZ = 0.1f;

        }

        m_transform.position += new Vector3(stepX, 0.0f, stepZ);
    }

    private void percentageStop()
    {

        float randomMove = Random.Range(0.0f, 1.0f);

        float stepX = 0;
        float stepZ = 0;

        if (randomMove < 0.2) // If to move based on elements
        {

            stepX = -0.1f;

        }
        else if (randomMove < 0.6)
        {

            stepX = 0.1f;

        }
        else if (randomMove < 0.2)
        {

            stepZ = -0.1f;

        }
        else if (randomMove < 0.2)
        {

            stepZ = 0.1f;

        }

        m_transform.position += new Vector3(stepX, 0.0f, stepZ);

    }

    private void stopVector()
    {

        float randomX = Random.Range(-0.0f, 0.1f);
        float randomZ = Random.Range(-0.1f, 0.1f);

        m_transform.position += new Vector3(randomX, 0.0f, randomZ);
        

    }


    // Update is called once per frame
    void Update () {

        //  Stop();
        // stopArray();
        // percentageStop();
        // stopCurve();
        stopVector();
    }
}
