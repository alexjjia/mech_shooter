using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	public GameObject enemy;
	public GameObject player;
	float boundX, boundY, boundZ;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnEnemy", 5, Random.value * 5);
	}
	
	// Update is called once per frame
	void Update () {
		boundX = player.transform.position.x + Random.Range(-40, 40);
		boundY = Random.Range (0, 10);
		boundZ = player.transform.position.z + Random.Range (-40, 40);
	}

	void SpawnEnemy()
	{
		Instantiate (enemy);
		enemy.transform.position = (new Vector3 (boundX, boundY, boundZ));
	}
}
