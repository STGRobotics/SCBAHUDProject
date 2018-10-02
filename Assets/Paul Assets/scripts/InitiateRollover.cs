using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InitiateRollover : MonoBehaviour {

	public GameObject manager;
	public GameObject target;

	// Use this for initialization
	void Start () {
		manager = GameObject.Find("InputManager");
		target = manager.GetComponent<GazeManager>().HitObject;
	}
	
	// Update is called once per frame
	void Update () {
		target = manager.GetComponent<GazeManager>().HitObject;
		if (target == gameObject){
			Debug.Log("initiated");
			Rollover();
		}
	}

	void Rollover(){
		Debug.Log("INITIATED");
		GameObject.Find("MiddleCenterText").SetActive(true);
		GameObject.Find("EvacuationPath").SetActive(true);
	}
}
