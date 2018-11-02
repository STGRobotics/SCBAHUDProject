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
	private Vector3 pos3;
	// distance between positions
	private float dist;
	private GameObject fireText;
	// variable for image fill attribute of temperature gauge component
	Image fillImg;
	private bool fireInstantiated = false;
	private float dist2;

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
		pos3 = new Vector3(0.81f, -3.05f, 21.25f);
		dist = 1;
		dist2 = 1;
		fillImg = this.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		// update player/camera position every frame
		pos1 = player.transform.position;
		// update distance between player/camera and fire every frame
		dist = Vector3.Distance(pos1, pos2);
		Debug.Log(dist2 + " meters");
		Debug.Log(temp + " degrees");

		dist2 = Vector3.Distance(pos1, pos3);
		// temperature is some number - distance so that it gets hotter as the user gets closer
		temp = 500 - dist2*dist2;

		// if the user is close enough to the fire and hasn't failed yet
		if (dist < 8 && GameObject.FindWithTag("FailureText") == null && GameObject.FindWithTag("FailureText2") == null){
			// the fire appears!
			if (!fireInstantiated){
				Instantiate(GameObject.Find("FirePrefab"), pos3, Quaternion.identity);
				fireInstantiated = true;
				GameObject.FindWithTag("InstructionsText").SetActive(false);
				fireText.SetActive(true);
				GameObject.Find("FirePrefab(Clone)").transform.Rotate(0,0,90f);
			}
		}
		// as long as the temperature does not reach 300 (distance is 0, or you're in the fire)
		if (temp < 500)
		{
			// temperature gauge fill amount update
			fillImg.fillAmount = temp / 500; 
		}
	}
}