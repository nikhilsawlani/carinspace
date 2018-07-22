using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeUp : MonoBehaviour {

	public Text timerr;
	 Timer timer = new Timer();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){

		timer.timeleft = timer.timeleft + 20.0f;
		timerr.text = "nik";  //timer.timeleft.ToString ("F1");
		Debug.Log (timer.timeleft.ToString ());
		Object.Destroy (this.gameObject);
	}
}
