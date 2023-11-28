using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteText : MonoBehaviour {

	public GameObject FPSController;
	private Text text;
	private int plane;
	// Use this for initialization

	void Start () {
		//text = GetComponent<Text>();
		text.text = "You won!";
		text.color = new Color(0, 0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (FPSController = null) {
			text.color = new Color (0, 0, 0, 1);
		}
	}
}
