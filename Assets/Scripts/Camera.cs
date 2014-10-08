using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("q"))
		{
			transform.RotateAround(Vector3.zero, Vector3.up, 90);
		}

		if (Input.GetKeyDown("e"))
		{
			transform.RotateAround(Vector3.zero, Vector3.down, 90);
		}
	}
}
