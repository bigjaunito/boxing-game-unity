using System.Collections;
using UnityEngine;
using UnityEngine.AI;
public class NavMeshAgentScript : MonoBehaviour {


	public Transform player;
	NavMeshAgent agent;

	void Start ()
	{
		player = GameObject.Find("player").transform;
		agent = GetComponent<NavMeshAgent> ();



	}

	void Update ()
	{		
		agent.SetDestination(player.position);
	}
}
