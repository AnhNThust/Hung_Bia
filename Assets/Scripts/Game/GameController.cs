using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameData _data;
    [SerializeField]
    private GameObject _gameOverPanel;

    private void Awake()
    {
        // reset so diem hien tai
        _data.ResetData();

        // load so diem cao nhat trong so cac lan choi truoc do
        _data.HighScore = PlayerPrefs.GetInt(Properties.HIGH_SCORE);
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
        // dung cac hoat dong o scene game
        Time.timeScale = 0f;

        // luu du lieu
        PlayerPrefs.SetInt(Properties.HIGH_SCORE, _data.HighScore);

        // bat game over panel len
        _gameOverPanel.SetActive(true);
    }
}
