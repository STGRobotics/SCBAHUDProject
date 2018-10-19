using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Used, attached to Temperature to increment fill amount of child image based on distance

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
	private bool fireInstantiated = false;

	// Use this for initialization
	void Start () {
		//remove floor quad
		Destroy(GameObject.Find("FloorQuad(Clone)"));

		player = GameObject.Find("MixedRealityCamera");
		// assign to variable to deactivate and activate later upon distance requirements
		fireText = GameObject.FindWithTag("FireText");
		fireText.SetActive(false);
		// get camera position (variable)
		pos1 = player.transform.position;
		// get fire position (static)
		pos2 = new Vector3(4.0f, 0.1f, 12.0f);
		dist = 1;
		fillImg = this.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		// update player/camera position every frame
		pos1 = player.transform.position;
		// update distance between player/camera and fire every frame
		dist = Vector3.Distance(pos1, pos2);
		//Debug.Log(dist + " meters");
		//Debug.Log(temp + " degrees");

		// temperature is some number - distance so that it gets hotter as the user gets closer
		temp = 300-dist*15;

		// if the user is close enough to the fire and hasn't failed yet
		if (dist < 5 && GameObject.FindWithTag("FailureText") == null && GameObject.FindWithTag("FailureText2") == null){
			// the fire appears!
			if (!fireInstantiated){
				Instantiate(GameObject.Find("FirePrefab"), pos2, Quaternion.identity);
				fireInstantiated = true;
				fireText.SetActive(true);
				GameObject.FindWithTag("InstructionsText").SetActive(false);
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
