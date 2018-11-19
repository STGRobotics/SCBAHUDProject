using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsDetector : MonoBehaviour {

	private GameObject camera;
	private GameObject prevTxt;
	private GameObject OOBText;
	private GameObject fire;

	// Use this for initialization
	void Start () {
		camera = GameObject.FindWithTag("MainCamera");
		OOBText = GameObject.FindWithTag("OOBText");
		OOBText.SetActive(false);
		prevTxt = GameObject.FindWithTag("OOBText");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "OOB"){
			OOBText.SetActive(true);

			if (GameObject.FindWithTag("EvacText")){
				prevTxt = GameObject.FindWithTag("EvacText");
				prevTxt.SetActive(false);
			}
			else if (GameObject.FindWithTag("FireText")){
				prevTxt = GameObject.FindWithTag("FireText");
				prevTxt.SetActive(false);
			}
			else if (GameObject.FindWithTag("InstructionsText")){
				prevTxt = GameObject.FindWithTag("InstructionsText");
				prevTxt.SetActive(false);
			}
			prevTxt.SetActive(false);
			if (GameObject.Find("FirePrefab(Clone)")){
				fire = GameObject.Find("FirePrefab(Clone)");
				fire.SetActive(false);
			}
		}
	}

	void OnCollisionExit(Collision col){
		if (col.gameObject.tag == "OOB"){
			Debug.Log("hmm??");
			OOBText.SetActive(false);
			fire.SetActive(true);
			prevTxt.SetActive(true);
		}
	}
}
