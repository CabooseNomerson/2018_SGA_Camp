﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCapitalShip : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector2.left * speed);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("UNSCFighter"))
		{
			Destroy(other.gameObject);
		}
	}
}
