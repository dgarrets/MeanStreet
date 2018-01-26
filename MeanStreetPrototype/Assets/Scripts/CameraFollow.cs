using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject car;
	public float distance = 1f;

	// Use this for initialization
	void Start (){
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = car.transform.position + (car.transform.forward * -(3f*distance)) + new Vector3(0,distance,0);
		transform.rotation = car.transform.rotation;
	}
}
