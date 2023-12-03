using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToPlayer : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if(_playerTransform != null && _agent.enabled)
        {
            _agent.SetDestination(_playerTransform.position);
        }
    }

    public void SetTarget(Transform playerTransform)
    {
        _playerTransform = playerTransform;
    }
}
