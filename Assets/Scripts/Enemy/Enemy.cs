using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Unit
{
	private GameObject player;
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		// Use this for initialization
		base.Start();
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector2.Distance(this.transform.position, player.transform.position) < 100)
		{
			AttackMove(player.transform,this.transform);
		}
	}

	
}
