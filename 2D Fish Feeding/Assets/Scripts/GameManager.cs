using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public GameObject howToPlayButton;
    public GameObject quitButton;
    public GameObject backButton;
    public GameObject panel;

    public Text coinHighScoreTxt;
    public Text highScoreTxt;

    [Header("Collectable")]
    public Text goldText;
    public static int goldValue;

    [Header("Score")]
    public Text scoreText;
    public static int scoreValue;


    private void Start()
    {
        panel.SetActive(false);
        backButton.SetActive(false);
        highScoreTxt.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
        coinHighScoreTxt.text = "Coins: " + PlayerPrefs.GetInt("coinhighscore");
    }

    private void Update()
    {
        scoreText.text = "" + scoreValue;

        goldText.text = "" + goldValue;

    }

    public void loadLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        goldValue = 0;
        scoreValue = 0;
    }

    public void HowToPlay()
    {
        panel.SetActive(true);
        backButton.SetActive(true);
        startButton.SetActive(false);
        howToPlayButton.SetActive(false);
        quitButton.SetActive(false);
    }

    // if back button is pressed, enable buttons

    public void Back()
    {
        panel.SetActive(false);
        backButton.SetActive(false);
        startButton.SetActive(true);
        howToPlayButton.SetActive(true);
        quitButton.SetActive(true);

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}