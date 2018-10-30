using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

//Used, attached to EvacPoint to initiate success

public class InitiateSuccess : MonoBehaviour {

	// input manager to get gazemanager component
	private GameObject manager;
	// variable to store the object we are currently targeting with our gaze
	private GameObject target;
	// game object that contains path of arrows to evacuation point
	private GameObject evacPath;
	// camera
	private GameObject player;
	// text alert upon success
	private GameObject successText;


	// Use this for initialization
	void Start () {
		manager = GameObject.Find("InputManager");
		// should start as null
		target = manager.GetComponent<GazeManager>().HitObject;
		// assigning to variable to deactivate and activate later upon success
		successText = GameObject.FindWithTag("SuccessText");
		evacPath = GameObject.FindWithTag("EvacPath");
		player = GameObject.Find("MixedRealityCamera");
		successText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		// re-assign what the user is gazing at every frame
		target = manager.GetComponent<GazeManager>().HitObject;
		if (target != null){
			//Debug.Log(target);
		}
		// if the target is the evacuation point and the user has activated the evacuation path and the user has not yet succeeeded and the user has not yet failed
		if (target == GameObject.Find("EvacPoint") && GameObject.FindWithTag("EvacPath") != null && GameObject.FindWithTag("SuccessText") == null && GameObject.FindWithTag("FailureText") == null && GameObject.FindWithTag("FailureText2") == null){
			// launch success sequence
			Success();
		}
	}

	void Success(){
		//Debug.Log("INITIATED SUCCESS");
		// deactivate evacuation text
		if (GameObject.FindWithTag("EvacText")){
			GameObject.FindWithTag("EvacText").SetActive(false);
		}
		successText.SetActive(true);
	}
}
