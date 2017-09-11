using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour {
	//test values.
	private float verticalTurn, horizontalTurn;
	public Camera mainCamera;
	public GameObject leftCannon;
	public GameObject rightCannon;
	public float turnSpeed;
	public int distance;
	public int projectileSpeed;
	private bool fireLeft;
	private bool fireRight;
	private float timestamp;
	private float fireDelay;
	// Use this for initialization
	void Start () {
		mainCamera.enabled = true;
		turnSpeed = 6;
		projectileSpeed = 500;
		fireLeft = false;
		fireRight = false;
		fireDelay = 0.2f;
	}
	
	// Update is called once per frame
	void Update () {
		horizontalTurn = Input.GetAxis ("RightJoystickX") * turnSpeed; //controls turning.
		//verticalTurn = Input.GetAxis ("RightJoystickY") * turnSpeed;
		transform.Rotate(new Vector3 (/**verticalTurn**/0, horizontalTurn, 0));
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


		////////////////////////////////////REMOVING BULLET MECHANICS FOR NOW
		//		if (Time.time >= timestamp) {					//Time.time controls the fire rate, so to speak. (i.e the delay between shots).
		//		
		//			if (fireLeft == true && fireRight == true) {		//shooting with both triggers at once.
		//				fire (leftCannon);
		//				fire (rightCannon);
		//			}/* else if (fireRight == true && fireLeft == true) {
		//				fire (leftCannon);
		//				fire (rightCannon);
		//			}*/ else if (fireLeft == false && fireRight == true) {		//shooting with only the right trigger.
		//				fire (rightCannon);
		//			} else if (fireRight == false && fireLeft == true) {		//shooting with only the left trigger.
		//				fire (leftCannon);
		//			}
		//			timestamp = Time.time + fireDelay;					//updates the 'timestamp' variable.
		//		}
		/////////////////////////////////////
		//	print ("BOOL STATUS: L - " + fireLeft + ", R - " + fireRight);
	}
	/////////////////////////////////////REMOVING BULLET MECHANICS FOR NOW
	/**
	 * Actual firing/shooting function.
	 * 
	 **/
	//	void fire(GameObject cannon)
	//	{
	//		GameObject projectile = Instantiate (bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
	//		Rigidbody rb = projectile.GetComponent<Rigidbody>();
	//
	//		rb.AddForce (projectile.transform.forward * projectileSpeed, ForceMode.Impulse);
	//		//print ("bullet's vector is at: " + bullet.transform.forward);
	//		Destroy (projectile, 10.0f);
	//	}
	/////////////////////////////////////
}
