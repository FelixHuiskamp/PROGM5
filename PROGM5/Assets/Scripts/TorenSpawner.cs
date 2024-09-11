using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TorenSpawner : MonoBehaviour
{
  
    public GameObject towerPrefab;

    public Vector3 minSpawnPosition = new Vector3(-10, 0, -10);
    public Vector3 maxSpawnPosition = new Vector3(10, 0, 10);

    public Vector3 minScale = new Vector3(0.5f, 0.5f, 0.5f);
    public Vector3 maxScale = new Vector3(2.0f, 2.0f, 2.0f);
    void Start()
    {

        GameObject tower = Instantiate(towerPrefab);
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            Vector3 randomPosition = new Vector3(Random.Range(minSpawnPosition.x, maxSpawnPosition.x), Random.Range(minSpawnPosition.y, maxSpawnPosition.y), Random.Range(minSpawnPosition.z, maxSpawnPosition.z));
            GameObject newTower = Instantiate(towerPrefab, randomPosition, Quaternion.identity);

            Vector3 randomScale = new Vector3(Random.Range(minScale.x, maxScale.x), Random.Range(minScale.y, maxScale.y), Random.Range(minScale.z, maxScale.z));

            newTower.transform.localScale = randomScale;
        }
    }
}
