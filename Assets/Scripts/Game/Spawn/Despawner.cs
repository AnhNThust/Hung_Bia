using UnityEngine;

public class Despawner : MonoBehaviour
{
    [SerializeField]
    private GameConfig _config;

    private int _catcherLife;

    private void Awake()
    {
        _catcherLife = _config.CatcherLife;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Beer"))
        {
            //Debug.Log("Life - 1");
            // dua game object beer quay tro ve pool
            ObjectPooler.Instance.ReturnObjectToPool(collision.gameObject);

            // - 1 mang cua nguoi choi
            LoseLife();
        }
    }

    /// <summary>
    /// ham giam 1 mang
    /// </summary>
    public void LoseLife()
    {
        //_catcherLife--;
        GameEvents.LifeChange(--_catcherLife);

        if (_catcherLife <= 0)
        {
            GameEvents.PlayerDeath();
        }
    }
}
