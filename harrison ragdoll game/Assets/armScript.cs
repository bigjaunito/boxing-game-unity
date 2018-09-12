using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class armScript : MonoBehaviour {
	Quaternion StartingRotation;
	public Quaternion HitRotation;
	public Text scoreText;
	private int score = 0;
	public Text winText;
	void Start() {
		StartingRotation = transform.rotation;
		//CurrentRotation = StartingRotation;
	}


	void Update() {
		if (Input.GetMouseButtonDown (0)) {
			transform.Rotate (0, 320, 60);
			//	transform.localRotation = HitRotation;
			//Sword.transform.Rotate (Vector3.forward * Time.deltaTime * 1440);
			//CurrentRotation = Sword.transform.rotation;
			//Sword.transform.rotation = Quaternion.Euler (0, 0, 65);
			Invoke ("RotateSword", 0.1f);
		} 
	

	}

	void RotateSword() {
		transform.localRotation = StartingRotation;
		//transform.Rotate (Vector3.forward * Time.deltaTime * -1440);
	}

	public void increaseScore()
	{
		score += 1;
		scoreText.text = "Score: " + score;
		if (score == 12)
		{
			winText.gameObject.SetActive(true);
		} 
	}

}
