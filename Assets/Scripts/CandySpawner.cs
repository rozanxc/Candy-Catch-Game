using UnityEngine;
using System.Collections;
                            

public class CandySpawner : MonoBehaviour
{
    public GameObject candyPrefab;
    public float minSpawnDelay = 1.0f;
    public float maxSpawnDelay = 3.0f;
    public int maxCandies = 15;

    private int candiesSpawned = 0;

    void Start()
    {
        StartCoroutine(SpawnCandies());
    }

    IEnumerator SpawnCandies()
    {
        while (candiesSpawned < maxCandies)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            Instantiate(candyPrefab, new Vector3(Random.Range(-2.5f, 2.5f), 5.0f, 0), Quaternion.identity);
            candiesSpawned++;
        }
    }
}
