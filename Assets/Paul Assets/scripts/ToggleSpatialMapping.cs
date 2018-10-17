using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Unused, attempted to turn off/on SpatialMapping with keycode attached to voice command

public class ToggleSpatialMapping : MonoBehaviour {

	public GameObject SpatialMapping;

	// Use this for initialization
	void Start () {
		SpatialMapping = GameObject.Find("SpatialMapping");
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown(KeyCode.Tab))
			{
				if (SpatialMapping.activeSelf)
				{
					SpatialMapping.SetActive(false);
				}
				else 
				{
					SpatialMapping.SetActive(true);
				}
			}
	}
}
