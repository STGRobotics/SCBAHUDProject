using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadcrumbTrail : MonoBehaviour {

	List<Vector3> positions = new List<Vector3>();

	private int frames = 0;
	private int ind = 0;
	public GameObject Camera;

	// Use this for initialization
	void Start () {
		Camera = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		frames++;
		if (frames % 10 == 0){
			positions[ind] = Camera.transform.position;
			//SetPositions(positions);
			ind++;
		}
	}
}
