using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnTime = 2f;

    void Start()
    {
        InvokeRepeating(
            "SpawnEnemy",
            1f,
            spawnTime
        );
    }

    void SpawnEnemy()
    {
        float randomX =
        Random.Range(-8f, 8f);

        Vector2 spawnPos =
        new Vector2(randomX,
        transform.position.y);

        Instantiate(
            enemyPrefab,
            spawnPos,
            Quaternion.identity
        );
    }
}
