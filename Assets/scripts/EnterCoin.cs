using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterCoin : MonoBehaviour {
	
	public Text score;
	int currentscore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter()
	{
		currentscore += 5;

		score.text = currentscore.ToString ();

		Object.Destroy (this.gameObject);
	}
}
