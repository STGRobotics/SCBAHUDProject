using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintToDebugText : MonoBehaviour {

	GameObject debugText;


	// Use this for initialization
	void Start () {
		debugText = GameObject.FindWithTag("DebugText");
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("FirePrefab(Clone)") != null){
			//debugText.GetComponent<Text>().text = GameObject.Find("FirePrefab(Clone)").transform.position + "\n" + gameObject.transform.position;
		}
		else {
			//debugText.GetComponent<Text>().text = "\n" + gameObject.transform.position;
		}
	}
}
