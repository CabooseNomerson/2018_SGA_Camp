using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoDraw : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDrawGizmos()
	{
		if (gameObject.name == "SpawnerRight")
		{
			//assigns color
			Gizmos.color = new Color(0, 0, 1, 1);

			//draws gizmo
			Gizmos.DrawCube(transform.position, new Vector3(2, 2, 0));
		}

		if (gameObject.name == "SpawnerTop")
        {
            //assigns color
			Gizmos.color = new Color(1, 0.92f, 0.016f, 1);

            //draws gizmo
            Gizmos.DrawCube(transform.position, new Vector3(2, 2, 0));
        }

		if (gameObject.name == "SpawnerBottom")
        {
            //assigns color
            Gizmos.color = new Color(1, 0, 1, 1);

            //draws gizmo
            Gizmos.DrawCube(transform.position, new Vector3(2, 2, 0));
        }
	}
}
