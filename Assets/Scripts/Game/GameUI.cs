using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    // thanh phan cua giao dien gameplay
    [SerializeField]
    private Text _scoreText;
    [SerializeField]
    private Text _lifeText;

    // thanh phan cua Game Over Panel
    [SerializeField]
    private Transform _gameOverPanel;

    // data va config
    [SerializeField]
    private GameConfig _config;
    [SerializeField]
    private GameData _data;

    private void Awake()
    {
        //score = data.currentScore;
        _scoreText.text = $"Score: {_data.CurrentScore}";
        _lifeText.text = $"Life: {_config.CatcherLife}";
    }

    private void OnEnable()
    {
        GameEvents.OnScoreChange += UpdateScore;
        GameEvents.OnLifeChange += UpdateLife;
    }

    private void OnDisable()
    {
        GameEvents.OnScoreChange -= UpdateScore;
        GameEvents.OnLifeChange -= UpdateLife;
    }

    private void UpdateScore(int score)
    {
        _data.CurrentScore = score;
        _scoreText.text = $"Score: {_data.CurrentScore}";
    }

    private void UpdateLife(int life)
    {
        _lifeText.text = $"Life: {life}";
    }
}
