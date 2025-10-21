using UnityEngine;

public class SpanwDosCanos : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightOffset = 2f;

    private float timer = 0f;

    void Update()
    {
        // Cronômetro simples
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(-heightOffset, heightOffset);
        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }

  
}
