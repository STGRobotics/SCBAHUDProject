﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	private GameObject target;
	private GameObject failureText2;
	private GameObject player;

	// Use this for initialization
	void Start () {
		// assign to variables to deactivate and then reactivate later upon gazing at the fire
		failureText2 = GameObject.FindWithTag("FailureText2");
		failureText2.SetActive(false);
		player = GameObject.Find("MixedRealityCamera");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
    {
    	//Debug.Log(col.gameObject.name);
    	// if fire collides with camera/player, failure sequence
        if(col.gameObject.name == "MixedRealityCamera")
        {
            failureText2.SetActive(true);
            if (GameObject.FindWithTag("EvacText")){
				GameObject.FindWithTag("EvacText").SetActive(false);
			}
			if (GameObject.FindWithTag("FireText")){
				GameObject.FindWithTag("FireText").SetActive(false);
			}
        }
    }
}