using UnityEngine;

public class SpanwDosCanos : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightOffset = 2f;

    private void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, spawnRate);
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(-heightOffset, heightOffset);
        Instantiate(pipePrefab, new Vector3(10, randomY, 0), Quaternion.identity);
    }
}