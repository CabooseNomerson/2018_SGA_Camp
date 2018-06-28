using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject Enemy;
	public float Interval;
	private float lastEnemy;

	[Header("Enemy Spawning")]


	public int MaxSpawned;
	//[HideInInspector]
	public int NumSpawned;

	[Space]

    [Header ("Fighter Spawning")]

	public int FighterMaxSpawned;
    //[HideInInspector]
    public int FighterNumSpawned;


    [Header ("Screen Bounds")]
	public float ScreenLeft;
	public float ScreenRight;
	[Space]
	public float ScreenTop;
	public float ScreenBottom;

    


	// Use this for initialization
	void Start () 
	{
		//spawns an enemy right away
		SpawnEnemy();
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time - Interval >= lastEnemy)
		{
			SpawnEnemy();
		}

		if (Time.time - Interval >= lastEnemy && gameObject.name == "FighterSpawner")
        {
			SpawnFighter();
        } 
	}

    void SpawnEnemy()
	{

		if (NumSpawned <= MaxSpawned)
		{
			transform.position = new Vector2(Random.Range(ScreenLeft, ScreenRight), Random.Range(ScreenTop, ScreenBottom));

			Instantiate(Enemy, transform.position, transform.rotation);

			lastEnemy = Time.time;

			NumSpawned++;
		}
	}

	void SpawnFighter()
	{
		if (FighterNumSpawned <= FighterMaxSpawned)
        {
            transform.position = new Vector2(Random.Range(ScreenLeft, ScreenRight), Random.Range(ScreenTop, ScreenBottom));

            Instantiate(Enemy, transform.position, transform.rotation);
            
            lastEnemy = Time.time;

            FighterNumSpawned++;
        }
	}
}
