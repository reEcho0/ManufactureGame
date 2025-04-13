using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameScore : MonoBehaviour
{
    public static GameScore instance;
    public PauseGameConrtoller pause;
    public PlayerController player;
    public Text scoreText, highscoreText;
    int score, highscore;

    private void Awake()
    {
        instance = this;
        if (PlayerPrefs.HasKey("SaveScore"))
        { highscore = PlayerPrefs.GetInt("SaveScore"); }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        highscoreText.text = "Highscore: " + highscore;
        if (!pause.isPaused && player.isAlive)
            instance.AddScore();
    }

    public void AddScore()
    {
            score++;
            Highscore();
    }

    public void Highscore()
    {
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("SaveScore", highscore);
        }
    }

    public void ResetScore()
    {
        score = 0;
    }
}
