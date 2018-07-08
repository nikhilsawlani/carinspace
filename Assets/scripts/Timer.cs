using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	public Text timer;
	float timeleft = 60.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeleft -= Time.deltaTime;
		timer.text = timeleft.ToString ("F1");
		if (timeleft < 0) {
			SceneManager.LoadScene (1);

		}
	}
}
