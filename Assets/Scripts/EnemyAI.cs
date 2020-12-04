using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour {
    private NavMeshAgent agent;
    private Vector3 target;
    private Animator ani;
	// Use this for initialization
	void Start () {
        ani = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        ani.SetBool("Run", true);
        target = GameObject.FindGameObjectWithTag("Finish").transform.position;
        target.x = Random.Range(-10f, 10f);
        agent.destination = target;
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(transform.position, target) > 0.5f)
        {
            ani.SetBool("Run", true);
        }
        else
        {
            ani.SetBool("Run", false);
        }
	}
}
