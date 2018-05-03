using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour {
    public Transform target;
    private NavMeshAgent navAgent;
	// Use this for initialization
	void Start () {
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.SetDestination(target.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
