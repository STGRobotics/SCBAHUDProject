using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Used, attached to SpatialMapping to print status of activation

public class BlinkText : MonoBehaviour {

	private float frame;
	private bool on;

	// Use this for initialization
	void Start () {
		frame = 0;
		on = true;
	}
	
	// Update is called once per frame
	void Update () {
		frame++;
		if (frame > 29){
			frame = 0;
			if (on){
				gameObject.GetComponent<Text>().text = "";
				on = false;
			}
			else {
				gameObject.GetComponent<Text>().text = "ALERT!!\nFIRE INITIATED ROLLOVER!\nEVACUATE TO SAFETY!";
				on = true;
			}
		}
	}
}
