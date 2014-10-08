using UnityEngine;
using System.Collections;

public class MenuBlock : MonoBehaviour {

	public GameObject block;
	float rX = Random.Range (0,10);
	float rY = Random.Range (0,10);
	float rZ = Random.Range (0,10);



	// Use this for initialization
	void Start () {
		Instantiate(block, new Vector3(Random.Range (0f,10f),Random.Range (0f,10f),Random.Range (0f,10f)), new Quaternion(0,0,0,0));
	}
	
	// Update is called once per frame
	void Update () {
		if ((rigidbody != null) && rigidbody.IsSleeping()) {
			rigidbody.WakeUp();
		}
	}
}
