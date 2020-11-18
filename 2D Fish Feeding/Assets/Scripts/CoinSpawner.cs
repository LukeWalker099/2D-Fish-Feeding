using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    private float screenX;
    private float screenY;

    public GameObject coinPrefab;


    public void Awake()
    {
        screenX = Random.Range(-4.45f, 6f);
        screenY = Random.Range(6.45f, 8.32f);
    }

    private void Start()
    {
        InvokeRepeating("spawnCoins", Random.Range(1, 3), Random.Range(14, 26));
    }

    private void spawnCoins()
    {
        GameObject a = Instantiate(coinPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(screenX * -1, 5.45f), screenY);
    }
}










