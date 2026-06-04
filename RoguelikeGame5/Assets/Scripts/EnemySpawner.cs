using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnTime = 2f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTime)
        {
            timer = 0f;
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-5f, 5f);

        Vector2 spawnPos = new Vector2(x, y);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}