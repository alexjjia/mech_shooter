using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour {
	//test values.
	private float verticalTurn, horizontalTurn;
	public Camera mainCamera;
	public GameObject leftCannon;
	public GameObject rightCannon;
	public GameObject left_muzzle, right_muzzle;
	public float turnSpeed;
	public int distance;
	public int projectileSpeed;
	public bool fireLeft;
	public bool fireRight;
	private float timestamp;
	private float fireDelay;

	private Reticle crosshair;

	// Use this for initialization
	void Start () {
		mainCamera.enabled = true;
		turnSpeed = 6;
		projectileSpeed = 500;
		fireLeft = false;
		fireRight = false;
		fireDelay = 0.2f;
		left_muzzle.SetActive (false);
		left_muzzle.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		horizontalTurn = Input.GetAxis ("RightJoystickX") * turnSpeed; //controls turning.
		verticalTurn = Input.GetAxis ("RightJoystickY") * turnSpeed;
		transform.rotation = Quaternion.RotateTowards (transform.rotation, (Quaternion.Euler(verticalTurn*10,horizontalTurn*30,0)), Time.deltaTime*250f);
		//transform.rotation = (Quaternion.AngleAxis(30, (new Vector3(verticalTurn, horizontalTurn, 0))));

		//Other input controls.
		if (Input.GetAxis ("LeftTrigger") > 0) {		//if left trigger is pressed, set shooting flag to true.
			fireLeft = true;
			//			Debug.Log ("fireLeft: " + fireLeft);
		}
		if (Input.GetAxis ("RightTrigger") > 0) {		//if right trigger is pressed, set shooting flag to true.
			fireRight = true;
			//			Debug.Log ("fireRight: " + fireRight);
		}
		if (Input.GetAxis ("LeftTrigger") == 0) {		//if left trigger is released, set shooting flag to false.
			fireLeft = false;
			//			Debug.Log ("fireLeft: " + fireLeft);
		}
		if (Input.GetAxis ("RightTrigger") == 0) {		//if right trigger is released, set shooting flag to false.
			fireRight = false;
			//			Debug.Log ("fireRight: " + fireRight);
		}
			
				if (Time.time >= timestamp) {					//Time.time controls the fire rate, so to speak. (i.e the delay between shots).
				
			if (fireLeft == true && fireRight == true) {		//shooting with both triggers at once.
				left_muzzle.SetActive (true);
				right_muzzle.SetActive (true);
			//	fire (leftCannon);
			//	fire (rightCannon);
			} else if (fireLeft == false && fireRight == true) {		//shooting with only the right trigger.
				left_muzzle.SetActive (false);
				right_muzzle.SetActive (true);
			//	fire (rightCannon);
			} else if (fireRight == false && fireLeft == true) {		//shooting with only the left trigger.
				left_muzzle.SetActive (true);
				right_muzzle.SetActive (false);
		//		fire (leftCannon);
			} else {
				left_muzzle.SetActive (false);
				right_muzzle.SetActive (false);
			}
					timestamp = Time.time + fireDelay;					//updates the 'timestamp' variable.
				}
		//	print ("BOOL STATUS: L - " + fireLeft + ", R - " + fireRight);
	}

//	/**
//	 * Actual firing/shooting function.
//	 * 
//	 **/
//		void fire(GameObject cannon)
//		{
//		//	GameObject projectile = Instantiate (bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
//		//	Rigidbody rb = projectile.GetComponent<Rigidbody>();
//	
//		//	rb.AddForce (projectile.transform.forward * projectileSpeed, ForceMode.Impulse);
//			//print ("bullet's vector is at: " + bullet.transform.forward);
//		//	Destroy (projectile, 10.0f);
//		}
}
