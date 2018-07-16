using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit {

	// Use this for initialization
	void Start () {
		base.Start();
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)	 && Input.GetKey(KeyCode.A))
		{
			Move(45);
		}
		else if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
		{
			Move(315);
		}
		else if(Input.GetKey(KeyCode.S)	 && Input.GetKey(KeyCode.A))
		{
			Move(135);
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
		{
			Move(225);
		}
		else if (Input.GetKey(KeyCode.W))
		{
			Move(0);	
		}
		else if (Input.GetKey(KeyCode.A))
		{
			Move(90);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			Move(180);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			Move(270);
		}
	}
}
