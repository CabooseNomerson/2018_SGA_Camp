using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNSCTargeting : MonoBehaviour {

	private GameObject Enemy;

	public float turnspeed;
	public float MaxMagnitudeDelta;
	private float TurnSpeed;

	public float FireRate;
	private float NextFire;


	public GameObject MAC;
	private Transform GoliathMAC;
	private Transform DobMAC;
	//private Vector3 TargetDifference;


	// Use this for initialization
	void Start () 
	{
		GoliathMAC = GameObject.Find("GoliathMAC").transform;
		DobMAC = GameObject.Find("DobMAC").transform;


	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.Space) && Time.time > NextFire)
		{
            //reset the NextFire timer to a point that is FireRate seconds in the future
			NextFire = Time.time + FireRate;

			Instantiate(MAC, GoliathMAC.transform.position, transform.rotation);
			Instantiate(MAC, DobMAC.transform.position, transform.rotation);
		}

		//Trying to get the UNSC ships to rotate toward enemies in a restricted angle

        

		//constantly assign a target
		Enemy = GameObject.FindWithTag("Enemy");


		if (Enemy != null)
		{
			//find the direction of the target
			Vector3 TargetDifference = Enemy.transform.position - transform.position;

			//      //set the speed to turn
			////TurnSpeed = Time.deltaTime * turnspeed;

			//set the Vector3 direction to rotate towards
			Quaternion NewDirection = Quaternion.LookRotation(TargetDifference);
			//Vector3 finalCheatDir = new Vector3(0, 0, NewDirection.eulerAngles.x);
			//transform.eulerAngles= finalCheatDir;

			transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, Mathf.Atan2(TargetDifference.y, TargetDifference.x) * Mathf.Rad2Deg);

            //draw a debug gizmo
			Debug.DrawRay(transform.position, TargetDifference, Color.red);
		}


	

		////actually turn towards the target
		////float rotationZ = 
		////transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, rotationZ);
        
	}
}
