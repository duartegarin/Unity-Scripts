using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateObject : MonoBehaviour {

	public float xSpeed = 0;
	public float ySpeed = 0;
	public float zSpeed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(xSpeed*Time.deltaTime,ySpeed*Time.deltaTime,zSpeed*Time.deltaTime);
	}
}
