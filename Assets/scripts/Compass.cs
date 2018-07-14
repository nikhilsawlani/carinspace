using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour {


	public Vector3 northdir;
	public Transform player;
	public Quaternion missiondir;

	public RectTransform northlayer;
	public RectTransform missionlayer;

	public Transform missioplace;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ChangeNorthDir ();
		ChangeMissionDir ();
	}


	public void ChangeNorthDir(){

		northdir.z = player.eulerAngles.y;
		northlayer.localEulerAngles = northdir;
	}

	public void ChangeMissionDir(){

		Vector3 dir = transform.position - missioplace.position;

		missiondir = Quaternion.LookRotation (dir);

		missiondir.z = -missiondir.y;
		missiondir.x =0;
		missiondir.y =0;

		missionlayer.localRotation = missiondir * Quaternion.Euler (northdir);


	}
}
