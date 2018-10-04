using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemperatureScanner : MonoBehaviour {

	private GameObject player;
	private GameObject fire;
	public float temp = 0;
	// position of the player/camera
	private Vector3 pos1;
	// position of the fire
	private Vector3 pos2;
	// distance between positions
	private float dist;
	private GameObject fireText;
	// variable for image fill attribute of temperature gauge component
	Image fillImg;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("MixedRealityCamera");
		fire = GameObject.Find("Fire");
		// assign to variable to deactivate and activate later upon distance requirements
		fireText = GameObject.FindWithTag("FireText");
		fireText.SetActive(false);
		// get camera position (variable)
		pos1 = player.transform.position;
		// get fire position (static)
		pos2 = fire.transform.position;
		dist = 1;
		fillImg = this.GetComponent<Image>();
		fire.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		// update player/camera position every frame
		pos1 = player.transform.position;
		// update distance between player/camera and fire every frame
		dist = Vector3.Distance(pos1, pos2);
		Debug.Log(dist + " meters");
		//Debug.Log(temp + " degrees");

		// temperature is some number - distance so that it gets hotter as the user gets closer
		temp = 300-dist;

		// if the user is close enough to the fire and hasn't failed yet
		if (dist < 75 && GameObject.FindWithTag("FailureText") == null){
			// the fire appears!
			fire.SetActive(true);
			// if the user has found the fire and gazed at it while close, but hasn't failed yet
			if (GameObject.FindWithTag("EvacText") && GameObject.FindWithTag("FailureText") == null){
				// deactivate the text that tells the user to locate the fire
				fireText.SetActive(false);
			}
			// otherwise...
			else {
				// activate the text that tells the user to locate the fire
				fireText.SetActive(true);
			}
			
		}
		// as long as the temperature does not reach 300 (distance is 0, or you're in the fire)
		if (temp < 300)
		{
			// temperature gauge fill amount update
			fillImg.fillAmount = temp / 300; 
		}
	}
}
