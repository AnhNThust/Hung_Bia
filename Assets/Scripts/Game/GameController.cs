using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameData data;
    public GameObject gameOverPanel;

    private void Awake()
    {
        data.ResetData();

        // load high score
        data.highScore = PlayerPrefs.GetInt(Properties.HIGH_SCORE);
    }

    private void OnEnable()
    {
        GameEvents.OnPlayerDeath += GameOver;
    }

    private void OnDisable()
    {
        GameEvents.OnPlayerDeath -= GameOver;
    }

    private void GameOver()
    {
        // Freeze Game Scene
        Time.timeScale = 0f;

        // Save Data
        PlayerPrefs.SetInt(Properties.HIGH_SCORE, data.highScore);

        // enable game over panel
        gameOverPanel.SetActive(true);
    }
}
