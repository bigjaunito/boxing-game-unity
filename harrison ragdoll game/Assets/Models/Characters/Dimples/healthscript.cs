using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthscript : MonoBehaviour {

	public float TotalHp;
	public float CurrentHp;

	// Use this for initialization
	void Start () {
		CurrentHp = TotalHp;
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetMouseButtonDown (0)||Input.GetMouseButtonDown (1)) && CurrentHp > 0.29f) {
			TakeDamage ();
		
		} else {
		
		}


	}
	void TakeDamage()
	{
		CurrentHp -= 0.29f;
		transform.localScale = new Vector3 ((CurrentHp), 0.4f, 1);
	}

}
