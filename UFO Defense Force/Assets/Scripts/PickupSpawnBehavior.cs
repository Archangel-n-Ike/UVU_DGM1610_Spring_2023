using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawnBehavior : MonoBehaviour
{
    public GameObject[] pickupPrefabs;
    
    private float spawnRangeX = 19f;
    private float spawnPosZ = 19f;
    private float startDelay = 5f;
    private float spawnInterval = 20f;
    private float spawnIntRange = 20f;

    void Start()
    {
        float pickupSpawnInt = Random.Range(-spawnIntRange, spawnIntRange);
        InvokeRepeating("SpawnPickup", startDelay, pickupSpawnInt);
    }

    void SpawnPickup()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        int pickupIndex = Random.Range(0,pickupPrefabs.Length);
        Instantiate(pickupPrefabs[pickupIndex], spawnPos, pickupPrefabs[pickupIndex].transform.rotation);
    }
}
