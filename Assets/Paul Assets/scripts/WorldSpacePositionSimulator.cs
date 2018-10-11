using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSpacePositionSimulator : MonoBehaviour {

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("MixedRealityCamera");
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = new Vector3(0f - Mathf.Abs(player.transform.position.x), 0f - Mathf.Abs(player.transform.position.y), 0f - Mathf.Abs(player.transform.position.z));
	}
}
