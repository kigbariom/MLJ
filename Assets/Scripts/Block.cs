using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0, -100, 0);
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((rigidbody != null) && rigidbody.IsSleeping()) {
			rigidbody.WakeUp();
		}
	}
}
