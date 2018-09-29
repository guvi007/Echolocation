using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour {

	public GameObject obstacle;
	public float delayTimer=3f;
	float timer;

	// Use this for initialization
	void Start () {
		timer = delayTimer;
	}

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 obstaclePos = new Vector3 (transform.position.x, Random.Range (-1.5f, 1.5f), transform.position.z);

			Instantiate (obstacle, obstaclePos, transform.rotation);
			timer = delayTimer;
		}

	}
}
