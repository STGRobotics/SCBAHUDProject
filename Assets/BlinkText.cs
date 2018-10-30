using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Used, attached to SpatialMapping to print status of activation

public class BlinkText : MonoBehaviour {

	private float frame;
	private bool on;
	private GameObject obj;

	// Use this for initialization
	void Start () {
		frame = 0;
		on = true;
		obj = GameObject.FindWithTag("EvacText");
		obj.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		frame++;
		//Debug.Log(obj);
		if (!GameObject.FindWithTag("FireText") && !GameObject.FindWithTag("SuccessText") && !GameObject.FindWithTag("FailureText") && !GameObject.FindWithTag("FailureText2") && !GameObject.FindWithTag("InstructionsText")){
			if (frame > 59){
				frame = 0;
				if (on){
					//Debug.Log("off");
					obj.SetActive(false);
					on = false;
				}
				else {
					//Debug.Log("on");
					obj.SetActive(true); 
					on = true;
				}
			}
		}	
	}
}
