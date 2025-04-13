using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseAfterLossController : MonoBehaviour
{
    public GameObject endGame;
    public PlayerController player;
    public GameScore gameScore;
    public static PauseAfterLossController instance;
    public Text scoreText, highscoreText;
    int score, highscore;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.isAlive)
        {
            endGame.SetActive(true);
            scoreText.text = gameScore.scoreText.text;
            highscoreText.text = gameScore.highscoreText.text;
            Time.timeScale = 0f;
        }
        
    }

    public void Restart()
    {
        player.isAlive = true;
        endGame.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
