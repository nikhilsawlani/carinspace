using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour {

	public Text health;
	public int currenthealth;
	void Start(){

		int.TryParse (health.text, out currenthealth);
	}
	void OnTriggerEnter()
	{
		 //currenthealth = int.Parse(health.ToString());
		currenthealth -= 5;
		health.text = (currenthealth).ToString();
		if (currenthealth < 1) {

			SceneManager.LoadScene (1);
		}

		Debug.Log ("in enter");
		Debug.Log (currenthealth.ToString());

	}

	void Update(){
		int.TryParse (health.text, out currenthealth);
	}
}
