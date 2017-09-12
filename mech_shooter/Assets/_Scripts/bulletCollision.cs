using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollision : MonoBehaviour {
	private bool leftFire, rightFire; //used to store the respective bools from the TurretController script.
	public bool lockedOn;
	public GameObject crosshair;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = new Vector3 (0, 0, 0.5f);
		lockedOn = false;
	}

	// Update is called once per frame
	void Update () {
		leftFire = 	GameObject.Find ("Turret").GetComponent<TurretController> ().fireLeft;
		rightFire = GameObject.Find ("Turret").GetComponent<TurretController> ().fireRight;
		transform.position = crosshair.transform.position + offset;

	}
	void OnCollisionEnter (Collision col)
	{
		lockedOn = true;
		if (col.gameObject.CompareTag ("Enemy")) {
			if (leftFire == true || rightFire == true)
			{
				Destroy (col.gameObject);
				crosshair.GetComponent<Reticle> ().score += 100;
				lockedOn = false;
			}
		}
	}
}
