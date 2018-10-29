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
	private bool growFire = false;
	private float dist;

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
		dist = 1;
	}
	
	// Update is called once per frame
	void Update () {
		// update the target of the user's gaze every frame
		target = manager.GetComponent<GazeManager>().HitObject;
		if (GameObject.Find("Cylinder")){
			dist = Vector3.Distance(player.transform.position, GameObject.Find("Cylinder").transform.position);
		}
		
		if (target != null){
			//Debug.Log(target.name);
			// if the user gazes at the fire and has not failed yet
			if (manager.GetComponent<SimpleSinglePointerSelector>().down && dist < 4){
				if (GameObject.FindWithTag("FailureText") == null && GameObject.FindWithTag("FailureText2") == null && GameObject.FindWithTag("SuccessText") == null){
					// fire begins to rollover
					Rollover();
				}
			}
		}
		if (growFire){
			GameObject.Find("FirePrefab(Clone)").transform.GetChild(0).transform.GetChild(0).transform.localScale += new Vector3(0.001f,.0075f,.0075f);
		}
		if (GameObject.FindWithTag("SuccessText")){
			growFire = false;
		}	
	}

	void Rollover(){
		//Debug.Log("INITIATED ROLLOVER");
		// evacuation time!w
		if (GameObject.FindWithTag("InstructionsText")){
			GameObject.FindWithTag("InstructionsText").SetActive(false);
		}
		if (GameObject.FindWithTag("FireText")){
			GameObject.FindWithTag("FireText").SetActive(false);
		}
		if (GameObject.Find("Cylinder")){
			GameObject.Find("Cylinder").SetActive(false);
		}
		GameObject.Find("Line").SetActive(false);
		evacText.SetActive(true);
		evacPath.SetActive(true);
		growFire = true;

	}
}
