using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float MoveSpeed = 10;
	
	void Start()
	{
	}
	// Update is called once per frame
	
	void Update () 
	{
		if (Input.GetKeyDown ("r")) {  
			Application.LoadLevel ("game");  
		}

		// Amount to Move
		float MoveUD = Input.GetAxis("Zertical") * MoveSpeed * Time.deltaTime;
		float MoveFB = Input.GetAxis("Vertical")  * MoveSpeed * Time.deltaTime;
		float MoveLR = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
		
		
		// Move the player
		transform.Translate(Vector3.forward * MoveFB);
		transform.Translate(Vector3.up * MoveUD);
		transform.Translate(Vector3.right * MoveLR);
		
	}
}
