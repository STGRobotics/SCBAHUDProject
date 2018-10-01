using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateRollover : MonoBehaviour {

	public GazeManager gazemanager = GameObject.Find("InputManager").GetComponent<GazeManager>();
	public GameObject target = new GameObject();

	// Use this for initialization
	void Start () {
		target = gazemanager.getHitObject();
	}
	
	// Update is called once per frame
	void Update () {
		target = gazemanager.getHitObject();
		if (target == gameObject){
			Rollover();
		}
	}

	void Rollover(){
		GameObject.Find("MiddleCenterText").SetActive(true);
		GameObject.Find("EvacuationPath").SetActive(true);
	}
}
