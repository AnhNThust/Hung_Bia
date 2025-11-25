using UnityEngine;

public class Catcher : MonoBehaviour
{
    [SerializeField]
    private GameData _data;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Beer"))
        {
            //Debug.Log("score + 1");
            ObjectPooler.Instance.ReturnObjectToPool(collision.gameObject);
            AddScore();
        }
    }

    public void AddScore()
    {
        GameEvents.ScoreChange(++_data.CurrentScore);
        if (_data.CurrentScore > _data.HighScore)
            _data.HighScore = _data.CurrentScore;
    }
}
