using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNSCTargeting : MonoBehaviour {

	private Transform Enemy;

	public float turnspeed;
	public float MaxMagnitudeDelta;
	private float TurnSpeed;

	public GameObject MAC;
	private Transform GoliathMAC;
	private Transform DobMAC;


	// Use this for initialization
	void Start () 
	{
		GoliathMAC = GameObject.Find("GoliathMAC").transform;
		DobMAC = GameObject.Find("DobMAC").transform;

	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(MAC, GoliathMAC.transform.position, Quaternion.identity);
			Instantiate(MAC, DobMAC.transform.position, Quaternion.identity);
		}

		//Trying to get the UNSC ships to rotate toward enemies in a restricted angle

        

		////constantly assign a target
		//Enemy = GameObject.FindWithTag("Enemy").transform;

		////find the direction of the target
		//Vector3 TargetDifference = Enemy.position - transform.position;

  //      //set the speed to turn
		////TurnSpeed = Time.deltaTime * turnspeed;
        
  //      //set the Vector3 direction to rotate towards
		////Vector3 NewDirection = Vector3.RotateTowards(transform.position, TargetDifference, TurnSpeed, MaxMagnitudeDelta);


		//transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, Mathf.Atan2(TargetDifference.y, TargetDifference.x) * Mathf.Rad2Deg);

  //      //draw a debug gizmo
		////Debug.DrawRay(transform.position, NewDirection, Color.red);

		////actually turn towards the target
		////float rotationZ = 
		////transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, rotationZ);
        
	}
}
