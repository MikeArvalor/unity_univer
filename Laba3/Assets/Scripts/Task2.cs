using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    private int counter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision myCollision)
    {
        switch (myCollision.gameObject.name)
        {
            case "Floor":
                Debug.Log("Hit the floor");
                break;
            case "Wall1":
                Debug.Log("Hit the Wall_1");
                break;
            case "Wall2":
                Debug.Log("Hit the Wall_2");
                break;
        }
        //if (myCollision.gameObject.name == "Floor")
        //{

        //}
    }
}
