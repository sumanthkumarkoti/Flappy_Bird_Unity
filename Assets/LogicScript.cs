using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject playScreen;
    public Text highScoreText;

    public float startingPipeSpeed = 5f;
    public float speedIncreasePerPoint = 0.1f;

    public AudioSource audioSource;
    public AudioClip gameOverSound;

    private bool gameOverTriggered = false;

    void Start()
    {
        Time.timeScale = 0f;
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0);
    }

    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();

        IncreaseDifficulty();
    }

    void IncreaseDifficulty()
    {
        float newSpeed = startingPipeSpeed + (playerScore * speedIncreasePerPoint);

        PipeMoveScript[] pipes = FindObjectsByType<PipeMoveScript>(FindObjectsSortMode.None);

        foreach (PipeMoveScript pipe in pipes)
        {
            pipe.moveSpeed = newSpeed;
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if (gameOverTriggered) return;

        gameOverTriggered = true;

        if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            PlayerPrefs.Save();
        }

        gameOverScreen.SetActive(true);
        audioSource.PlayOneShot(gameOverSound);
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        playScreen.SetActive(false);
        Time.timeScale = 1f;
    }
}