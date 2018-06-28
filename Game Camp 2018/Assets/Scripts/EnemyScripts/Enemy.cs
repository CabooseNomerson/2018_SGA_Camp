using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed;

    //range to player
	private float range;

	private Transform PlayerTransform;

	public float MinDistance;

	public int[] EnemyTags;
	private int selectedTag;

	// Use this for initialization
	void Start () 
	{
		//selectedTag = Random.Range(EnemyTags[0], EnemyTags.Length);

		//if(selectedTag == 0)//EnemyTags[0]
		//{
		//	gameObject.tag = "Enemy1";         
		//}

		//if (selectedTag == 1)//EnemyTags[1]
        //{
        //    gameObject.tag = "Enemy2";
        //}


		//PlayerTransform = GameObject.Find("Player").transform;
		PlayerTransform = GameObject.Find("Earth").transform;

	}//end of Start


	//-------------------------------------------------------------------------------------------------------------


	// Update is called once per frame
	void Update () {

		range = Vector2.Distance(transform.position, PlayerTransform.position);

        //since it updates every frame, it will track constantly
        if (range > MinDistance) 
			//if the current range of the enemy is further than the min distance to player
		{
			//Vector2.moveTowards(current position, target position, speed)
			transform.position = Vector2.MoveTowards(transform.position, PlayerTransform.position, Time.deltaTime * speed);
		}

	//	transform.Translate(Vector2.left * speed);
	}//end of Update


    //-------------------------------------------------------------------------------------------------------------

    
	private void OnTriggerEnter2D(Collider2D other)
    {
		//print("collided, no loop");

        if (other.gameObject.name == "Player")
        {
            //kill player?
        }


        //if the enemy hits Earth
		if (other.gameObject.name == "Earth")
		{
			Destroy(gameObject);
            //remove points/lives
		}
    }//end of OnTriggerEnter2D
}
