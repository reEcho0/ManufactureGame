using UnityEngine;
using UnityEngine.UI;

public class GetHighscoreMenu : MonoBehaviour
{
    public static GetHighscoreMenu instance;
    public Text highscoreText;
    int highscore;

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
        highscoreText.text = "Highscore: " + highscore;
    }
}
