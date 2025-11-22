using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    private int life = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Beer"))
        {
            Debug.Log("Life - 1");
            collision.gameObject.SetActive(false);
            DescLife();
        }
    }

    public void DescLife()
    {
        life--;
        GameEvents.LifeChange(life);

        if (life <= 0)
        {
            GameEvents.PlayerDeath();
        }
    }
}
