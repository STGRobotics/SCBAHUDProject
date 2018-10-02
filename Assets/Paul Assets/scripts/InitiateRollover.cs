using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InitiateRollover : MonoBehaviour {

	public GameObject manager;
	public GameObject target;
	public GameObject evacText;
	public GameObject evacPath;
	private bool evac;

	// Use this for initialization
	void Start () {
		manager = GameObject.Find("InputManager");
		target = manager.GetComponent<GazeManager>().HitObject;
		evacText = GameObject.FindWithTag("EvacText");
		evacPath = GameObject.FindWithTag("EvacPath");
		evacText.SetActive(false);
		evacPath.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		target = manager.GetComponent<GazeManager>().HitObject;
		if (target == gameObject){
			Rollover();
		}
	}

	void Rollover(){
		Debug.Log("INITIATED");
		evacText.SetActive(true);
		Debug.Log("one");
		evacPath.SetActive(true);
		Debug.Log("done");
	}
}
