using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class rightarmscript : MonoBehaviour {
	Quaternion StartingRotation;
	public Quaternion HitRotation;


	void Start() {
		StartingRotation = transform.rotation;
		//CurrentRotation = StartingRotation;
	}


	void Update() {
		if (Input.GetMouseButtonDown (1)) {
			transform.Rotate (0, 350, 60);
			//	transform.localRotation = HitRotation;
			//Sword.transform.Rotate (Vector3.forward * Time.deltaTime * 1440);
			//CurrentRotation = Sword.transform.rotation;
			//Sword.transform.rotation = Quaternion.Euler (0, 0, 65);
			Invoke ("rotaterightarm", 0.1f);
		} 


	}

	void rotaterightarm() {
		transform.localRotation = StartingRotation;
		//transform.Rotate (Vector3.forward * Time.deltaTime * -1440);
	}


}
