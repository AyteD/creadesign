using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineGroundAgent : MonoBehaviour
{
    [SerializeField] private MoveRandom _moveRandom;
    [SerializeField] private MoveToPlayer _moveToPlayer;

    private void Start()
    {
        _moveToPlayer.enabled = false;
        _moveRandom.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _moveRandom.enabled = false;
            _moveToPlayer.enabled = true;
            _moveToPlayer.SetTarget(other.GetComponent<Transform>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _moveToPlayer.enabled = false;
            _moveRandom.enabled = true;
        }       
    }
}
