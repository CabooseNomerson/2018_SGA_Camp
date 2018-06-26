using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject Enemy;
	public float Interval;
	private float lastEnemy;


    [Header ("Screen Bounds")]
	public float ScreenLeft;
	public float ScreenRight;
	[Space]
	public float ScreenTop;
	public float ScreenBottom;

    


	// Use this for initialization
	void Start () 
	{
		SpawnEnemy();      
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time - Interval >= lastEnemy)
		{
			SpawnEnemy();
		}
	}

    void SpawnEnemy()
	{
		transform.position = new Vector2(Random.Range(ScreenLeft, ScreenRight), Random.Range(ScreenTop, ScreenBottom));

        Instantiate(Enemy, transform.position, transform.rotation);

        lastEnemy = Time.time;
	}
}
