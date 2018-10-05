using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerForHUD : MonoBehaviour {

	//component attribute for how filled the radial image of the gauge is
	Image fillImg;
	// timer in seconds for air supply
	public float timeAmt = 300;
	// time
	float time;
	// text alert for failure
	private GameObject failureText;

	// Use this for initialization
	void Start () {
		fillImg = this.GetComponent<Image>();
		time = timeAmt;
		// we assign it to a variable before setting it to inactive so we can activate it upon failure
		failureText = GameObject.FindWithTag("FailureText");
		failureText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		// timer should stop running once user succeeds
		if (GameObject.FindWithTag("SuccessText") == null && GameObject.FindWithTag("FailureText") == null && GameObject.FindWithTag("FailureText2") == null){
			// assuming there's still time, execute
			if (time > 0)
			{
				// drain image based on elapsed time
				time -= Time.deltaTime;
				fillImg.fillAmount = time / timeAmt; 
			}
			// if time runs out
			else {
				// set failure text active
				failureText.SetActive(true);
				// deactivate all other possible texts
				if (GameObject.FindWithTag("EvacText")){
					GameObject.FindWithTag("EvacText").SetActive(false);
				}
				if (GameObject.FindWithTag("FireText")){
					GameObject.FindWithTag("FireText").SetActive(false);
				}
			}
		}
	}
}
