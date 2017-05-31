using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	private Vector3 velocity;
	public float Speed;
	public bool Authorized;
	public int NumberOfPredictableCollisions;
	public Vector3[] PredictedCollisionPoints;

	void Awake(){
		transform.Rotate (0, Random.Range (20, 360), 0);
		velocity = transform.forward;
		Speed = 20;
	}

	void OnCollisionEnter(Collision col){
		for (int i = 0; i < col.contacts.Length; i++) {
			velocity = 2 * (Vector3.Dot (velocity, col.contacts [i].normal.normalized)) * col.contacts [i].normal.normalized - velocity;
			velocity *= -1;
			transform.forward = velocity;
		}
	}

	void OnDrawGizmos()
	{
		DrawDirectionLine ();
	}

	void DrawDirectionLine()
	{
		Debug.DrawLine (transform.position,transform.position+(transform.forward*10),Color.red);
	}

	void Update(){
		DealWithMovement ();
	}

	void DealWithMovement()
	{
		if (Input.GetKeyDown(KeyCode.Space)) {
			Authorized = true;
		}
		if(Authorized)
			transform.position += velocity * Time.deltaTime * Speed;
	}

	void PredictCollisions()
	{
		
	}
}
