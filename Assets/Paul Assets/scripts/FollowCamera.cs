using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	public GameObject camera;
	public Vector3 offset;

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//gameObject.GetComponent<RectTransform>().position = new Vector3(camera.transform.position.x + offset.x, camera.transform.position.y + offset.y, camera.transform.position.z + offset.z);
		float step = speed * Time.deltaTime;

		gameObject.GetComponent<RectTransform>().position = Vector3.MoveTowards(gameObject.GetComponent<RectTransform>().position, new Vector3(camera.transform.position.x + offset.x, camera.transform.position.y + offset.y, camera.transform.position.z + offset.z), step);
		
	}
}

