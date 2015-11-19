using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour {

	private Vector3 velocity = Vector3.zero;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	//Get a movement Vec
	public void Move (Vector3 _velocity)
	{
		velocity = _velocity;
	}

	// Run every iteration
	void FixedUpdate ()
	{
		PerformMovement();
	}

	//perform movement
	void PerformMovement ()
	{
		if (velocity != Vector3.zero)
		{
			rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

		}
	}
}
