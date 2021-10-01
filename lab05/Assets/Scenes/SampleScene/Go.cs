using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go : MonoBehaviour
{

    bool moveRight = true;
    public float speed = 4f; //unit per second
    public int WaitForSecond = 1;


    // first point 


    void Update()
    {

        if (WaitForSecond < Time.time)
        {
            if (moveRight)
            {
                var pos = transform.position;
                pos.z += speed * Time.deltaTime * 3;
                transform.position = pos;
                if (pos.z > 4.5f) moveRight = false;
            }
            else
            {
                var pos = transform.position;
                pos.z -= speed * Time.deltaTime * 3;
                transform.position = pos;
                if (pos.z < -12.5f) moveRight = true;
            }
        }


    }
}