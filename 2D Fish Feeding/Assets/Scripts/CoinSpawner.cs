using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;


    private void Start()
    {
        InvokeRepeating("spawnCoin", Random.Range(2f, 4f), Random.Range(16f, 30f));
    }

    public void spawnCoin()
    {
        int randomItem = 0;
        GameObject coinPrefab;

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            coinPrefab = spawnPool[randomItem];

            screenX = Random.Range(-7.5f, 7f);
            screenY = Random.Range(6.45f, 14.30f);
            pos = new Vector2(screenX, screenY);

            Instantiate(coinPrefab, pos, coinPrefab.transform.rotation);
        }

    }

}






