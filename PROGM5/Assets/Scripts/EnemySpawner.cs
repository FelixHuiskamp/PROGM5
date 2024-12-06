using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 1f;
    public int enemiesToSpawn = 3; 

    private List<GameObject> enemies;
    private float nextSpawnTime;

    void Start()
    {
        enemies = new List<GameObject>();
        nextSpawnTime = Time.time + spawnInterval;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            SpawnMultipleEnemies(100);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClearEnemies();
        }

        if (Time.time >= nextSpawnTime) 
        { 
            SpawnMultipleEnemies(enemiesToSpawn);
            nextSpawnTime = Time.time + spawnInterval; 
        }
    }

    void SpawnMultipleEnemies(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject newEnemy = Instantiate(enemyPrefab, GetRandomPosition(), Quaternion.identity);
            enemies.Add(newEnemy);
        }
    }

    void ClearEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        enemies.Clear();
    }

    Vector3 GetRandomPosition()
    {
        float x = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);
        return new Vector3 (x, 0, z);
    }
    
}
