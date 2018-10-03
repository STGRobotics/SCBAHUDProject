using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemperatureScanner : MonoBehaviour {

	private GameObject player;
	private GameObject fire;
	public float temp = 0;

	private Vector3 pos1;
	private Vector3 pos2;
	private float dist;
	private GameObject fireText;

	Image fillImg;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("MixedRealityCamera");
		fire = GameObject.Find("Fire");
		fireText = GameObject.FindWithTag("FireText");
		fireText.SetActive(false);
		pos1 = player.transform.position;
		pos2 = fire.transform.position;
		dist = 1;
		fillImg = this.GetComponent<Image>();
		fire.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		pos1 = player.transform.position;
		dist = Vector3.Distance(pos1, pos2);
		//Debug.Log(dist + " meters");
		//Debug.Log(temp + " degrees");

		temp = 300-dist;

		if (dist < 75){
			fire.SetActive(true);
			if (GameObject.FindWithTag("EvacText")){
				fireText.SetActive(false);
			}
			else {
				fireText.SetActive(true);
			}
			
		}

		if (temp < 300)
		{
			fillImg.fillAmount = temp / 300; 
		}
	}
}
