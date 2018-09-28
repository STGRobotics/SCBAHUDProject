using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleAirtankBar : MonoBehaviour {
	public Image bar;
	public RectTransform button;

	public float airVal = 0;

	public float myTimer = 300;


	// Update is called once per frame
	void Update () {
		AirChange(airVal);
		if (myTimer <= 0)
	    {
	    	//Game Over
	        //Destroy(transform.root.gameObject);
	    }
	    else {
	    	myTimer -= Time.deltaTime;
	    }
	    airVal = myTimer / 3;
		//gameObject.GetComponent<TextMesh>().text = "There are \n" + myTimer + " \nseconds left";
	}

	void AirChange(float airVal){
		float amount = (airVal/100.0f) * 180.0f/360;
		bar.fillAmount = amount;
		float buttonAngle = amount * 360;
		button.localEulerAngles = new Vector3(0, 0, -buttonAngle);
	}
}
