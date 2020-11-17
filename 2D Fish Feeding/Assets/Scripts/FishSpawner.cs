using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject predatorSpawner;
    public GameObject preySpawner;
    public GameObject preyLeftSpawner;

    private void Start()
    {
        InvokeRepeating("spawnPredator", Random.Range(6, 9), Random.Range(14, 25));
        InvokeRepeating("spawnPrey", Random.Range(1, 6), Random.Range(9, 18));
        InvokeRepeating("spawnPreyLeft", Random.Range(1, 6), Random.Range(9, 18));
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

}
