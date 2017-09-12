using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This script controls the muzzle flash animation by rotating four planes in perpindicular fashions by their Z-axis.
 * 
 **/
public class Muzzle_Rotator : MonoBehaviour {
	public GameObject left_muzzle;
	public GameObject right_muzzle;

	// Update is called once per frame
	void Update () {
		left_muzzle.transform.Rotate (new Vector3 (0, 0, Time.deltaTime * 1000f));
		right_muzzle.transform.Rotate (new Vector3 (0, 0, Time.deltaTime * 1000f));
	}
}
