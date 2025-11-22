using UnityEngine;

public class Catcher : MonoBehaviour
{
    //private int score = 0;
    public GameData data;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Beer"))
        {
            Debug.Log("score + 1");
            collision.gameObject.SetActive(false);
            AddScore();
        }
    }

    public void AddScore()
    {
        //score++;
        GameEvents.ScoreChange(++data.currentScore);
        if (data.currentScore > data.highScore)
            data.highScore = data.currentScore;
    }
}
