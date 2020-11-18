using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    private float spawnX;
    private float spawnY;

    // Fish Spawner
    public GameObject predatorSpawner;
    public GameObject preySpawner;
    public GameObject preyLeftSpawner;

    // Jelly Fish Spawner
    public GameObject jellyfishSpawner;

    private void Awake()
    {
        spawnX = Random.Range(-4.30f, 6.15f); // Min X / Max X
        spawnY = Random.Range(-6.55f, -6.56f); // Min Y / Max Y
    }

    private void Start()
    {
        InvokeRepeating("spawnPredator", Random.Range(6, 9), Random.Range(14, 25));
        InvokeRepeating("spawnPrey", Random.Range(1, 6), Random.Range(4, 9));
        InvokeRepeating("spawnPreyLeft", Random.Range(1, 6), Random.Range(6, 12));
        InvokeRepeating("spawnJellyFish", Random.Range(1, 3), Random.Range(14, 22));
    }

    private void spawnPredator()
    {
        Instantiate(predatorSpawner, new Vector2(-10f, 3.6f), Quaternion.identity);
    }

    private void spawnPrey()
    {
        Instantiate(preySpawner, new Vector2(-10f, 2.20f), Quaternion.identity);
    }

    private void spawnPreyLeft()
    {
        Instantiate(preyLeftSpawner, new Vector2(9.7f, 2.35f), Quaternion.identity);
    }

    private void spawnJellyFish()
    {
        GameObject a = Instantiate(jellyfishSpawner) as GameObject;
        a.transform.position = new Vector2(Random.Range(spawnX * -1, 6.15f), spawnY);
    }

}
