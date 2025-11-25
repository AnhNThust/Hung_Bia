using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField]
    private Text _currentScoreText;
    [SerializeField]
    private Text _highScoreText;
    [SerializeField]
    private GameData _data;

    private void OnEnable()
    {
        _currentScoreText.text = $"Score: {_data.CurrentScore}";
        _highScoreText.text = $"High Score: {_data.HighScore}";
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
