using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dots
{

    public class Script : MonoBehaviour
    {
        public GameObject dotPrefab;

        

        [SerializeField]
        private GameObject[] m_arrayDots;
        private Camera m_mainCam;
        private Transform m_transform;
        private Vector3 m_direction;
        public float force = 10;
        public float gravity = 9.81f;

        void Start()
        {
            m_arrayDots = new GameObject[10];

            for (int i = 0; i < m_arrayDots.Length; i++)
            {

                GameObject tempObject = Instantiate(dotPrefab);


                m_arrayDots[i] = tempObject;
                m_arrayDots[i].SetActive(false);
                
            }

            m_mainCam = Camera.main;
            m_transform = transform;
        }

        void Update()
        {
            if (Input.GetMouseButton(0))
            {

                Vector3 screenPos = m_mainCam.WorldToScreenPoint(m_transform.position);
                screenPos.z = 0;

                m_direction = (Input.mousePosition - screenPos).normalized;

                Aim();
            }

            if (Input.GetMouseButtonUp(0))
            {

                for (int i = 0; i < m_arrayDots.Length; i++)
                {
                    m_arrayDots[i].SetActive(false);
                }

            }
        }
         
        private void Aim()
        {

            float Sx = -m_direction.x * force;
            float Sy = -m_direction.y * force;
          
            for (int i = 0; i < m_arrayDots.Length; i++)
            {

                float t = i * 0.1f;
                float dx = m_transform.position.x + Sx * t;
                float dy = (m_transform.position.y + Sy * t) - (gravity * (t * t) * 0.5f);
                float dz = 0;

                m_arrayDots[i].transform.position = new Vector3(dx, dy, dz);

                m_arrayDots[i].SetActive(true);

            }

           
        }
    }

}                  