using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed;

	//private Rigidbody2D RB;


	// Use this for initialization
	void Start () 
	{

		Destroy(gameObject, 5);
		//RB = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector2.right * speed);
	}

	void OnTriggerEnter2D(Collider2D other)
    {

        //if a MAC round hits the bullet catcher
        //if (other.gameObject.name == "BulletCatcher")
        //{
        //    Destroy(gameObject);
        //}
       

        //if a MAC round hits an enemy
		if(other.gameObject.CompareTag("Enemy"))
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
            //add points
		}
    }
}
