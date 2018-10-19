using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InitiateRollover : MonoBehaviour {

	private GameObject manager;
	private GameObject target;
	private GameObject evacText;
	private GameObject evacPath;
	private GameObject player;

	//Used, attached to camera to initiate rollover/evacuation sequence

	// Use this for initialization
	void Start () {
		manager = GameObject.Find("InputManager");
		// gaze target starts null
		target = manager.GetComponent<GazeManager>().HitObject;
		// assign to variables to deactivate and then reactivate later upon gazing at the fire
		evacText = GameObject.FindWithTag("EvacText");
		evacPath = GameObject.FindWithTag("EvacPath");
		player = gameObject;
		evacText.SetActive(false);
		evacPath.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		// update the target of the user's gaze every frame
		target = manager.GetComponent<GazeManager>().HitObject;
		if (target != null){
			Debug.Log(target.name);
			// if the user gazes at the fire and has not failed yet
			if (target.name == "Cube" || target.name == "Fire Particle System"){
				if (GameObject.FindWithTag("FailureText") == null && GameObject.FindWithTag("FailureText2") == null && GameObject.FindWithTag("SuccessText") == null){
					// fire begins to rollover
					Rollover();
				}
				
			}
		}	
	}

	void Rollover(){
		//Debug.Log("INITIATED ROLLOVER");
		// evacuation time!
		evacText.SetActive(true);
		evacPath.SetActive(true);
	}
}
