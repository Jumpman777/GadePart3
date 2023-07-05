using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BullSpawner : MonoBehaviour
{
    public GameObject bullPrefab;
    public float spawnInterval = 4f;
    public float spawnDuration = 26f;
    public float bullLifetime = 10f; // Lifetime of the spawned bulls

    private float elapsedTime = 0f;
    private bool isSpawning = true;

    private void Start()
    {
        InvokeRepeating("SpawnBull", spawnInterval, spawnInterval);
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= spawnDuration)
        {
            isSpawning = false;
            CancelInvoke("SpawnBull");
        }
    }

    private void SpawnBull()
    {
        if (!isSpawning)
            return;

        // Get a random empty game object position to spawn the bull
        Transform spawnPoint = GetRandomSpawnPoint();

        // Instantiate the bull at the spawn point
        GameObject spawnedBull = Instantiate(bullPrefab, spawnPoint.position, spawnPoint.rotation);

        // Destroy the spawned bull after the specified lifetime
        Destroy(spawnedBull, bullLifetime);
    }

    private Transform GetRandomSpawnPoint()
    {
        // Get all the empty game objects with a specific tag from the scene
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag("spawnpoint");

        // Choose a random spawn point from the array
        int randomIndex = Random.Range(0, spawnPoints.Length);
        return spawnPoints[randomIndex].transform;
    }
}


