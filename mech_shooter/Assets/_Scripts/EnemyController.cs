using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
//	private TurretController turret;
//	private Reticle crosshair;

	private bool leftFire, rightFire, targetLockOn;
	// Use this for initialization
	void Start () {
		leftFire = false;
		rightFire = false;
		targetLockOn = false;
	}
	
	// Update is called once per frame
	void Update () {
		targetLockOn = GameObject.Find ("Reticle").GetComponent<Reticle> ().lockedOn;
		leftFire = 	GameObject.Find ("Turret").GetComponent<TurretController> ().fireLeft;
		rightFire = GameObject.Find ("Turret").GetComponent<TurretController> ().fireRight;
		Debug.Log("leftFire is: " + leftFire);
		Debug.Log ("rightFire is: " + rightFire);
		Debug.Log ("lockOn is: " + targetLockOn);


	}
	void OnTriggerEnter (Collider col)
	{
		if ((leftFire == true || rightFire == true) && targetLockOn) {
			if (col.gameObject.CompareTag("Player")) {
			//	Destroy (col.gameObject);
				gameObject.GetComponent<Renderer> ().material.color = new Color (Random.value, Random.value, Random.value, 1.0f);
			}
		}
	}
}
