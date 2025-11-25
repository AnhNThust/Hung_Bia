using UnityEngine;

public class BeerMovement : MonoBehaviour
{
    [SerializeField]
    private GameConfig _config;

    private float _speed;

    private void Awake()
    {
        _speed = _config.BeerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * _speed * Time.deltaTime * Vector3.up);
    }
}
