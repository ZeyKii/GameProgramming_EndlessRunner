using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ennemy;
    public GameObject target;
    public float ennemySpeed = 0.2f;
    public float speedIncrement = 0.5f;
    public float minimumInterval = 0.5f;
    public float maximumInterval = 2f;
    public float startDelay = 0f;

    private float nextSpawnTime;
    private bool gameStarted = false;

    void Start()
    {
        nextSpawnTime = Time.time + startDelay;
    }

    void Update()
    {
        if (!gameStarted && Time.time >= nextSpawnTime)
        {
            gameStarted = true;
            nextSpawnTime = Time.time + GetRandomSpawnInterval();
        }

        if (gameStarted && Time.time >= nextSpawnTime)
        {
            SpawnEnnemy();
            AdjustSpawnRate();
            nextSpawnTime = Time.time + GetRandomSpawnInterval();
        }
    }

    float GetRandomSpawnInterval()
    {
        return Random.Range(minimumInterval, maximumInterval);
    }

    void SpawnEnnemy()
    {
        GameObject asteroid = Instantiate(ennemy, transform.position, Quaternion.identity);
        Vector2 direction = (Vector2.left);
        asteroid.GetComponent<Rigidbody2D>().velocity = direction * ennemySpeed;
    }

    void AdjustSpawnRate()
    {
        ennemySpeed += speedIncrement;
    }
}
