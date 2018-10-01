using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemperatureScanner : MonoBehaviour {

	public GameObject player;
	public GameObject fire;
	public float temp = 0;

	private Vector3 pos1;
	private Vector3 pos2;
	private float dist;

	Image fillImg;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Main Camera");
		fire = GameObject.Find("Fire");
		pos1 = player.transform.position;
		pos2 = fire.transform.position;
		dist = 1;
		fillImg = this.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		pos1 = player.transform.position;
		pos2 = fire.transform.position;
		dist = DistanceBetweenVector3s(pos1, pos2);

		temp = 300-dist;

		if (temp < 300)
		{
			fillImg.fillAmount = temp / 300; 
		}
	}

	float DistanceBetweenVector3s(Vector3 start, Vector3 end){
		return start.x-end.x;
	}
}
