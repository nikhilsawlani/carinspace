using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCoins : MonoBehaviour {

	public Vector3[] randomcoins;
	// Use this for initialization
	void Start () {
		int randomnum = Random.Range (0, randomcoins.Length);
		transform.position = randomcoins [randomnum];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
