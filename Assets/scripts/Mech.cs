using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Utiliser le namespace AI pour que le NavMeshAgent soit accessible !
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{
    public Transform destinationTransform;
    NavMeshAgent agent;

    void Update()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = destinationTransform.position;
    }
}

