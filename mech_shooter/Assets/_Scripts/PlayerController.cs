using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Vector3 movementVector;
	private float verticalMove, horizontalMove;
	private CharacterController characterController;


	//public GameObject bullet;

//	public Camera secondaryCamera;
	public float moveSpeed;

	public float jumpPower;
	public float gravity;


	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController>();
		moveSpeed = 8;
		jumpPower = 8;
		gravity = 9.8f;
	}
	
	// Update is called once per frame
	void Update () {
		//Player Movement
		if (characterController.isGrounded) { //while the player is grounded, he/she can move.
			movementVector.y = 0; //resets the dood.
			movementVector = (transform.forward * Input.GetAxis ("LeftJoystickY") * moveSpeed) + (transform.right * Input.GetAxis("LeftJoystickX") * moveSpeed); //controls actual movement.

			if (Input.GetButtonDown ("A")) { //controls jumping.
				movementVector.y += jumpPower;
			}
		}

		movementVector.y -= gravity * Time.deltaTime;

		characterController.Move(movementVector * Time.deltaTime);

	}

}

