using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour {

	public GameObject[] numRocks;
	public GameObject spawn;
	public GameObject[] rocks;

	void Update () {
		numRocks = GameObject.FindGameObjectsWithTag ("Rock");

		if (numRocks.Length < 3) {
			Instantiate(rocks[Random.Range(0,3)], spawn.transform.position, spawn.transform.rotation);
		}
	}
}
