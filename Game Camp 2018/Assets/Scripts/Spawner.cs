using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject Enemy;

    [Header ("Screen Bounds")]

	public float ScreenLeft;
	public float ScreenRight;
	[Space]
	public float ScreenTop;
	public float ScreenBottom;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector2(Random.Range(ScreenLeft, ScreenRight), Random.Range(ScreenTop, ScreenBottom));

		Instantiate(Enemy, transform.position, Quaternion.identity);
	}
}
