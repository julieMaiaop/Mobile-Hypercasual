using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightOffset = 2f;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, spawnRate);
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(-heightOffset, heightOffset);
        Vector3 spawnPos = new Vector3(5f, randomY, 0);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}
