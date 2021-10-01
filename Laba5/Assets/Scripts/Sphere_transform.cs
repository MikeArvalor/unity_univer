using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_transform : MonoBehaviour
{
	//public float sphereSpeed = 5;
	private Rigidbody rb;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.AddForce(movement * 5);
	}
}
