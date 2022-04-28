using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] humanFood;
    private float spawnBoundaryX = 20;
    private float spawnPositionZ = 23;
    private float startDelay = 3;
    private float spawnInterval = 3;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn a dor running towards the player
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Spawns a random dog
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        if(animalIndex == 3)
        {
            Vector3 spawnPosition = new Vector3(27, 0, Random.Range(5, 15));
            Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
        }
        else
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnBoundaryX, spawnBoundaryX), 0, spawnPositionZ);
            Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
