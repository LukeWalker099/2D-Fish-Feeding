using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public Player player;
    private bool isPlayerDead;
    public GameObject restartButton;
    public GameObject quitButton;

    private void Start()
    {
        restartButton.SetActive(false);
        quitButton.SetActive(false);
    }

    private void Update()
    {
       
        if (player.currentHealth < 1)
        {
            isPlayerDead = true;
        }
        else
        {
            isPlayerDead = false;
        }

        {
            if (isPlayerDead)
            {
                Death();
            }
        }
    }

    public void Death()
    {
            isPlayerDead = true;
            restartButton.SetActive(true);
            quitButton.SetActive(true);

    }

   


}
