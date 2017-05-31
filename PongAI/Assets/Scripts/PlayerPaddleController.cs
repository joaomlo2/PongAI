using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleController : MonoBehaviour {

	public float Speed;

	void Update () {
		_ProcessMovement ();
	}

	void _ProcessMovement(){
		float mV = Input.GetAxis ("Vertical");
		Vector3 move = new Vector3 (0.0f, 0.0f, mV);
		GetComponent<Rigidbody> ().MovePosition (transform.position+(move*Speed));
	}
}
