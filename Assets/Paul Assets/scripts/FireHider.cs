﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHider : MonoBehaviour {

	//Unused, sets fire to inactive (place script on fire) and activates upon distance being less than 25

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("MixedRealityCamera");
		gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(Vector3.Distance(gameObject.transform.position, player.transform.position));
		if (Mathf.Abs(Vector3.Distance(player.transform.position, gameObject.transform.position)) < 25){
			gameObject.SetActive(true);
		}
	}
}
