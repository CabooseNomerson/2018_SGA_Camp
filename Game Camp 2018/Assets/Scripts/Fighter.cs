using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour {

	public float speed;

	//range to enemy
    private float range;

    //private Transform EnemyTransform;

    public float MinDistance;

	private GameObject Enemy;
	public float turnspeed;

	private Transform FighterBulletSpawn;

	public GameObject bullet;

	public float FireRate;
    private float NextFire;

    //finds closest enemy with a tag and returns that GameObj as the target
	//public GameObject FindClosestEnemy()
 //   {
 //       GameObject[] gos;
	//	GameObject closest;
 //       gos = GameObject.FindGameObjectsWithTag("Enemy");
 //       float distance = Mathf.Infinity;
 //       Vector3 position = transform.position;
 //       foreach (GameObject go in gos)
 //       {
 //           Vector3 diff = go.transform.position - position;
 //           float curDistance = diff.sqrMagnitude;
 //           if (curDistance < distance)
 //           {
 //               closest = go;
 //               distance = curDistance;
 //           }
 //       }
	//	return closest;
	//}

	// Use this for initialization
	void Start () 
	{
		//grabs the child gameobject
		FighterBulletSpawn = transform.GetChild(0).GetChild(0).transform;
	}
	
	// Update is called once per frame
	void Update () 
	{


		Enemy = GameObject.FindWithTag("Enemy");
			//FindClosestEnemy();

		range = Vector2.Distance(transform.position, Enemy.transform.position);

        //since it updates every frame, it will track constantly
        if (range > MinDistance)
			
        //if the current range of the enemy is further than the min distance to player
        {
            //Vector2.moveTowards(current position, target position, speed)
			transform.position = Vector2.MoveTowards(transform.position, Enemy.transform.position, Time.deltaTime * speed);
        }

        //tracking enemy
		Enemy = GameObject.FindWithTag("Enemy");


		if (Enemy != null)
        {
            //find the direction of the target
            Vector3 TargetDifference = Enemy.transform.position - transform.position;

            //Vector3 finalCheatDir = new Vector3(0, 0, NewDirection.eulerAngles.x);
            //transform.eulerAngles= finalCheatDir;

            transform.eulerAngles = new Vector3(0, 0, Mathf.LerpAngle(transform.eulerAngles.z, Mathf.Atan2(TargetDifference.y, TargetDifference.x) * Mathf.Rad2Deg, Time.deltaTime * turnspeed));
            
            //draw a debug gizmo
			Debug.DrawRay(transform.position, TargetDifference, Color.yellow);
			if (Time.time > NextFire)            
			{
				//reset the NextFire timer to a point that is FireRate seconds in the future
                NextFire = Time.time + FireRate;

                //spawn round
				Instantiate(bullet, FighterBulletSpawn.position, transform.rotation);
			}
        }


	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Enemy"))
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}



}
