using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishOnCollide : MonoBehaviour {

	//public Text levelCompleteText;
	// Use this for initialization
	void Start () {
		//Makes the level complete text invisible at the start.
		//levelCompleteText.color = new Color(0, 0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		//change to color of the text upon entering to black
		//levelCompleteText.text = "Congrats, you did it!";
		//levelCompleteText.color = new Color(0, 0, 0, 1);

	} 
}
