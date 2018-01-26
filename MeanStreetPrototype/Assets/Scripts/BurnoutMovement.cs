using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnoutMovement : MonoBehaviour {

	public float speed = 50;
	public float topSpeed = 50;
	public float turnForce = 50;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float inputY = Input.GetAxis("Vertical");
		Vector3 currentForwardVelocity = Vector3.Project (rb.velocity, transform.forward);
		rb.AddForce ((transform.forward * inputY * speed)*(1-(currentForwardVelocity.magnitude/topSpeed)));

		float inputX = Input.GetAxis ("Horizontal");
		rb.AddTorque (transform.up * (inputX * turnForce));
	}
}
