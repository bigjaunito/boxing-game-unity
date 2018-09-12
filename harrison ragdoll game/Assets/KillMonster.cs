using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KillMonster : MonoBehaviour {
	int count = 3;
	PlayerController bot;


	// Use this for initialization
	void Start(){
		bot = GameObject.FindWithTag("Player").GetComponent<PlayerController> ();
		//scoreText  = GameObject.FindWithTag("scoreText").GetComponentInChildren<player>;
	}
		

	void Update (){
		
	}



	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PlayerArm") {
			count -= 1;
			if (count == 0){
				
				this.gameObject.SetActive (false);
				bot.SpawnDuplicates();



		}


	}


}
}