using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public GameConfig config;
    public GameData data;

    public Text scoreText;
    public Text lifeText;

    // Game Over Panel
    public Transform gameOverPanel;
    public Text currentScoreText;
    public Text highScoreText;

    //private int score = 0;

    private void Awake()
    {
        //score = data.currentScore;
        scoreText.text = $"Score: {data.currentScore}";
        lifeText.text = $"Life: {config.catcherLife}";
    }

    private void OnEnable()
    {
        GameEvents.OnScoreChange += UpdateScore;
        GameEvents.OnLifeChange += UpdateLife;
        //GameEvents.OnPlayerDeath += GameOver;
    }

    private void OnDisable()
    {
        GameEvents.OnScoreChange -= UpdateScore;
        GameEvents.OnLifeChange -= UpdateLife;
        //GameEvents.OnPlayerDeath -= GameOver;
    }

    private void UpdateScore(int score)
    {
        data.currentScore = score;
        scoreText.text = $"Score: {data.currentScore}";
    }

    private void UpdateLife(int life)
    {
        lifeText.text = $"Life: {life}";
    }

    //private void GameOver()
    //{
    //    gameOverPanel.gameObject.SetActive(true);
    //    PlayerPrefs.SetInt(Properties.HIGH_SCORE, data.highScore);
    //    //currentScoreText.text = $"Score: {data.currentScore}";
    //    //highScoreText.text = $"High Score: {data.highScore}";
    //}
}
