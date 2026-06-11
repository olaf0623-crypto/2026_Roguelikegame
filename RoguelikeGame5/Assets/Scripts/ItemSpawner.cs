using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject speedItemPrefab;

    public float spawnInterval = 10f;

    public float minX = -8f;
    public float maxX = 8f;

    public float minY = -4f;
    public float maxY = 4f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;

            SpawnItem();
        }
    }

    void SpawnItem()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPos = new Vector3(randomX, randomY, 0);

        Instantiate(speedItemPrefab, spawnPos, Quaternion.identity);
    }
}