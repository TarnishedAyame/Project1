using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMonsterSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float screenWidth = 8;
    public float screenHeight = 10;
    public float fallingspeed = 50;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void SpawnEnemy()
    {
        float xCord = Random.Range(-screenWidth, screenWidth);
        float yCord = Random.Range(10, screenHeight);
        

        Vector2 spawnPoint = new Vector2 (xCord, yCord);
     

        Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);
    }

}
