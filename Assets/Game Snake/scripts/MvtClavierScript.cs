using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public int speed = 10;
	
	// Update is called once per frame
	void FixedUpdate () {
		
		float mouveHorizontal = Input.GetAxis("Horizontal");
		float mouveVertical = Input.GetAxis("Vertical");
		
		Vector3 mouvment = new Vector3(mouveHorizontal, 0, mouveVertical);
		rigidbody.AddForce(mouvment * speed * Time.deltaTime);
		
	}
}
