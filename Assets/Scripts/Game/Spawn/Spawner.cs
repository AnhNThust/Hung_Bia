using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameConfig _config;

    private float _xSpawn;
    private float _xLeLimit;
    private float _xRiLimit;
    private float _coolDown;

    private void Awake()
    {
        _xLeLimit = _config.SpLLimit;
        _xRiLimit = _config.SpRLimit;
        _coolDown = _config.CoolDown;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawning());
    }

    IEnumerator Spawning()
    {
        while (true)
        {
            yield return new WaitForSeconds(_coolDown);
            _xSpawn = Random.Range(_xLeLimit, _xRiLimit);
            GameObject beer = ObjectPooler.Instance.GetPooledObject();
            if (beer != null)
            {
                beer.transform.position = new Vector2(_xSpawn, transform.position.y);
                beer.SetActive(true);
            }
        }
    }
}
