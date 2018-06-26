using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCapitalShip : MonoBehaviour {

	public float speed;

	public float Health;

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

		if (other.CompareTag("MAC Round"))
		{
			Destroy(other.gameObject);

			//take damage to self         
			Health -= 10;
			print(Health);

			if (Health <= 0)
			{
				//add points
				//spawn new capital ship(s)
				Destroy(gameObject);
			}
            
        }
	}
}
