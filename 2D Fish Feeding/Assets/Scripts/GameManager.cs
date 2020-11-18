using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource clickSFX;


    [Header("Collectable")]
    public Text goldText;
    public static int goldValue;

    [Header("Score")]
    public Text scoreText;
    public static int scoreValue;

    private void Update()
    {
        scoreText.text = "" + scoreValue;

        goldText.text = "" + goldValue;
    }

    public void loadLevel()
    {
        SceneManager.LoadScene(1);
    }
}