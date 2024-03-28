using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExPlayer: MonoBehaviour
{
    public Rigidbody Rigidbody;
    public int Force = 100;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
void Update()
    {
        if (Input.GetMouseButtonDown(0))                              //충돌 물체가 존재할 경우
        {
           m_Rigidbody.AddForce
        }
    }
}

