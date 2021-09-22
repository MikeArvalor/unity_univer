
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Task_3 : MonoBehaviour
{
    // detects when the other transform is closer than closeDistance
    // this is faster than using Vector3.magnitude
    public Transform player;
    //public GameObject player;
    public float closeDistance = 5.0f;

    void Update()
    {
        if (player)
        {
            Vector3 offset = player.position - transform.position;
            float sqrLen = offset.sqrMagnitude;

            // square the distance we compare with

          

            if (sqrLen < closeDistance * closeDistance)
                {
               
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime);
                }

            

        }
    }
}