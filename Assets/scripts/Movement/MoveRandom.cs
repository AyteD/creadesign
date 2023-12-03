using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveRandom : MonoBehaviour
{
    [SerializeField] private float _radiusOfTheCircleForRandomDestination = 10f;
    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if(_agent.enabled && _agent.remainingDistance == 0)
        {
            Vector3 _destination = UnityEngine.Random.insideUnitCircle * (_radiusOfTheCircleForRandomDestination / 2);
            _destination.z = transform.position.z + _destination.y;
            _destination.x = transform.position.x + _destination.x;
            _destination.y = 0;
            _agent.SetDestination(_destination);
        }
    }
}
