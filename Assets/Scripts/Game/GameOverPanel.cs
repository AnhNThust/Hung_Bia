using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverPanel : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    public GameData data;

    private void OnEnable()
    {
        scoreText.text = $"Score: {data.currentScore}";
        highScoreText.text = $"High Score: {data.highScore}";
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
