using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

/**
 * A VERY basic 'compass'.
 * 
 * */
public class Compass : MonoBehaviour {
	private Vector3 northDirection;

	void Start()
	{
		northDirection = new Vector3 (0, 0, transform.position.z-100); //negative makes up for the flipped image.
	}
	// Update is called once per frame
	void Update () {
		updateNorth ();
	}

	public void updateNorth ()
	{
		transform.rotation = Quaternion.LookRotation (northDirection);
	}

}

