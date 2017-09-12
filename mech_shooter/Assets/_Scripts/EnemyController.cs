using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Basic debugging information is placed here
 * as well as VERY basic 'AI'.
 * */
public class EnemyController : MonoBehaviour {
//private bool leftFire, rightFire, targetLockOn;
	public GameObject player;
	private float speed;
	private float attackRange;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
//		leftFire = false;
//		rightFire = false;
//		targetLockOn = false;
		speed = 1f;
		transform.LookAt (player.transform); //all enemies start facing the player.
		attackRange = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		//if the enemy approaches within a set distance attackRange from the player, it will stop.
		transform.LookAt(player.transform);
		if(Mathf.Pow((this.transform.position.x - player.transform.position.x), 2) + Mathf.Pow((Mathf.Pow((this.transform.position.z - player.transform.position.z), 2)), 0.5f) > attackRange)
			{
			transform.position += transform.forward * speed * Time.deltaTime;
			}
//		targetLockOn = GameObject.Find ("Bullet").GetComponent<bulletCollision> ().lockedOn;
//		leftFire = 	GameObject.Find ("Turret").GetComponent<TurretController> ().fireLeft;
//		rightFire = GameObject.Find ("Turret").GetComponent<TurretController> ().fireRight;
//		Debug.Log("leftFire is: " + leftFire);
//		Debug.Log ("rightFire is: " + rightFire);
//		Debug.Log ("lockOn is: " + targetLockOn);


	}
}
