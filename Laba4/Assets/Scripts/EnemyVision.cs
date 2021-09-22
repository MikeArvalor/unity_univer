using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyVision : MonoBehaviour
{
    public GameObject pill;
    private bool angered = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
     

        Vector3 midVector = pill.transform.position - transform.position;
        float angle = Vector3.SignedAngle(midVector, transform.forward, Vector3.up);
        float dist = Vector3.Distance(transform.position, pill.transform.position);
        float dot = Vector3.Dot(midVector, transform.forward);
        Debug.Log(dot);
        if (dist < 30 && dot > 0)
        {
            angered = true;

            transform.Rotate(Vector3.up, -angle);
            transform.position = Vector3.MoveTowards(transform.position, pill.transform.position, Time.deltaTime);
        }
    }

}