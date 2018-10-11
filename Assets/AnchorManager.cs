using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;
using UnityEngine.XR;
using UnityEngine.XR.WSA.Persistence;

public class AnchorManager : MonoBehaviour {



	private void StoreLoaded(WorldAnchorStore store){
		//this.store = store;
	}

	// Use this for initialization
	void Start () {

		if (XRDevice.SetTrackingSpaceType(TrackingSpaceType.RoomScale)){
			Debug.Log("yas");
		}

		WorldAnchorStore.GetAsync(StoreLoaded);

		WorldAnchor anchor = GameObject.Find("WorldSpaceObjects").AddComponent<WorldAnchor>();
		//WorldAnchorManager.Instance.AttachAnchor(GameObject.Find("WorldSpaceObjects"), "objs");



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
