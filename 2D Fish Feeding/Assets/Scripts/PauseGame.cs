using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool isGamePaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseText;
    public GameObject resumeButton;
    public GameObject restartButton;
    public GameObject quitButton;

    private void Start()
    {
        pauseMenuUI.SetActive(false);
        pauseText.SetActive(false);
        restartButton.SetActive(false);
        resumeButton.SetActive(false);
        quitButton.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        pauseText.SetActive(false);
        resumeButton.SetActive(false);
        quitButton.SetActive(false);
        restartButton.SetActive(false);
        Time.timeScale = 1;
        isGamePaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseText.SetActive(true);
        restartButton.SetActive(true);
        resumeButton.SetActive(true);
        quitButton.SetActive(true);
        Time.timeScale = 0;
        isGamePaused = true;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        GameManager.scoreValue = 0;
        GameManager.goldValue = 0;
        Time.timeScale = 1;
        isGamePaused = false;
    }
}
