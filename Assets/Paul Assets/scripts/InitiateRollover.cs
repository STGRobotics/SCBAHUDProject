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

	// Use this for initialization
	void Start () {
		manager = GameObject.Find("InputManager");
		target = manager.GetComponent<GazeManager>().HitObject;
		evacText = GameObject.FindWithTag("EvacText");
		evacPath = GameObject.FindWithTag("EvacPath");
		player = GameObject.Find("MixedRealityCamera");
		evacText.SetActive(false);
		evacPath.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		target = manager.GetComponent<GazeManager>().HitObject;
		if (target != null){
			//Debug.Log(target);
		}
		if (target == GameObject.Find("Cube")){
			Rollover();
		}
	}

	void Rollover(){
		Debug.Log("INITIATED ROLLOVER");
		evacText.SetActive(true);
		//Debug.Log("one");
		evacPath.SetActive(true);
		//Debug.Log("done");
	}
}
