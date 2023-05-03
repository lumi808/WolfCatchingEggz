using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggsHandler : MonoBehaviour
{
    [SerializeField] private List<GameObject> _prefabs;
    [SerializeField] private List<Transform> spawnPositions;
    [SerializeField] private float timeToSpawn;

    private float currentTime;

    private void Update()
    {
        int randomPosition = Random.RandomRange(0, 4);
        int randomizer = Random.RandomRange(0, 10);
        int objectRandomIndex = (randomizer < 2)? 1 : 0;

        if (currentTime > 0)
            currentTime -= Time.deltaTime;
        else
        {
            SpawnObject(_prefabs[objectRandomIndex], spawnPositions[randomPosition]);
            currentTime = timeToSpawn;
        }
    }

    private void SpawnObject(GameObject objectToSpawn, Transform spawnPosition)
    {
        Instantiate(objectToSpawn, spawnPosition.position, spawnPosition.rotation);
    }
}
