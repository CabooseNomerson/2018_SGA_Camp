using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNSCTargeting : MonoBehaviour {

	private GameObject Enemy;//target enemy, assigned in Update()

	public float turnspeed;//speed that it rotates

	public float FireRate;//fire rate in seconds
	private float NextFire;//tracks the last fired round


	public GameObject MAC;//the MAC round prefab

	private Transform MACSpawn;//transform for spawning the round

	// Use this for initialization
	void Start () 
	{
		//assigning MAC spawn point through grabbing the FIRST child's transform
		MACSpawn = transform.GetChild(0).transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Input.GetKeyDown(KeyCode.Space) &&
		if (Time.time > NextFire && Enemy != null)
		{
            //reset the NextFire timer to a point that is FireRate seconds in the future
			NextFire = Time.time + FireRate;

			//spawn rounds at each UNSC Capital Ship's MACSpawn
			Instantiate(MAC, MACSpawn.transform.position, transform.rotation);
 		}
      
		//constantly assign a target, will find a new one if necessary
		Enemy = GameObject.FindWithTag("EnemyCapitalShip");

        //if there is an enemy assigned as a target
		if (Enemy != null)
		{
			//find the direction of the target
			Vector3 TargetDifference = Enemy.transform.position - transform.position;

			//Vector3 finalCheatDir = new Vector3(0, 0, NewDirection.eulerAngles.x);
			//transform.eulerAngles= finalCheatDir;

			transform.eulerAngles = new Vector3(0, 0, Mathf.LerpAngle(transform.eulerAngles.z, Mathf.Atan2(TargetDifference.y, TargetDifference.x) * Mathf.Rad2Deg, Time.deltaTime * turnspeed));

            //draw a debug gizmo
			Debug.DrawRay(transform.position, TargetDifference, Color.red);
		}


	

		////actually turn towards the target
		////float rotationZ = 
		////transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, rotationZ);
        
	}
}
