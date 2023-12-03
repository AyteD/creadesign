using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentManager : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;

    public void EnableAgent()
    {
        _agent.enabled = true;
    }

    public void DisableAgent()
    {
        if (_agent.enabled)
        {
            _agent.enabled = false;
        }        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            EnableAgent();
        }       
    }
}
