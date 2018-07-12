using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cons : MonoBehaviour {


	public Transform HighScore;

	public int CurrentScore;

	

	// Update is called once per frame
	void Update () {


		
	}


	public void ChangeScore(int amount)
	{
		CurrentScore += amount;

	}
}
