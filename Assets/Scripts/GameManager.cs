using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public TMPro.TextMeshProUGUI scoreText;
    
    public void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex != 2)
            score = 0;

        scoreText.text = "Score: " + score;
    }

    public void ScoreUpdate()
    {
        score++;
        scoreText.text = "Score: " + score;
        Debug.Log("Score: " + score);
    }

    public void MainMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        Time.timeScale = 1.0f; ;
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Leaderboard()
    {
        SceneManager.LoadScene(3);
    }
}
