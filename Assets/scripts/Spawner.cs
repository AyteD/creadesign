using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _prefab;
    [SerializeField] private int _areaMask;
    [SerializeField] private bool _autoSpawn = true;
    [SerializeField] private int _numberSpawnPrefab = 10;

    private Collider _spawnerCollider;

    private void Awake()
    {
        _spawnerCollider = GetComponent<Collider>();
    }

    private void Start()
    {
        if (_autoSpawn)
        {
            AutoSpawnPrefab();
        }
    }

    private void Update()
    {
        if (!_autoSpawn && Input.GetKeyDown(KeyCode.S))
        {
            SpawnPrefabs();
        }
    }

    private void AutoSpawnPrefab()
    {
        for (int i = 0; i < _numberSpawnPrefab; i++)
        {
            SpawnPrefabs();
        }
    }


    private void SpawnPrefabs()
    {
        Vector3 maxBounds = _spawnerCollider.bounds.max;
        Vector3 minBounds = _spawnerCollider.bounds.min;

        float rdPosX = UnityEngine.Random.Range(minBounds.x, maxBounds.x);
        float rdPosZ = UnityEngine.Random.Range(minBounds.z, maxBounds.z);

        Vector3 rdPos = new Vector3(rdPosX, 0, rdPosZ);

        if(NavMesh.SamplePosition(rdPos, out NavMeshHit hit, 3f, _areaMask))
        {
            Instantiate(_prefab.gameObject, hit.position, Quaternion.identity);
        }
    }
}
