using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float cooldown = COOL_DOWN;
    public GameObject beerObject;

    float xSpawn = 0f;
    float ySpawn = 6f;
    const float COOL_DOWN = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawning());
    }

    IEnumerator Spawning()
    {
        while (true)
        {
            yield return new WaitForSeconds(COOL_DOWN);
            xSpawn = Random.Range(-2.2f, 2.2f);
            GameObject beer = ObjectPool.SharedInstance.GetPooledObject();
            if (beer != null)
            {
                beer.transform.position = new Vector2(xSpawn, ySpawn);
                beer.SetActive(true);
            }
        }
    }
}
