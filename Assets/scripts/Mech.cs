using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mech : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(Vector3.zero);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}