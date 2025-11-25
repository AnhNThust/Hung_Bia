using UnityEngine;

public class CatcherMovement : MonoBehaviour
{
    [SerializeField]
    private GameConfig _config;

    private float _moveDirection;
    private float _lLimit;
    private float _rLimit;
    private float _speed;

    private void Awake()
    {
        _lLimit = _config.MovLLimit;
        _rLimit = _config.MovRLimit;
        _speed = _config.CatcherSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x += _moveDirection * _speed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, _lLimit, _rLimit);

        transform.position = pos;
    }

    // cac ham goi tu button
    public void MoveLeft()
    {

        _moveDirection = -1f;
    }

    public void MoveRight()
    {
        _moveDirection = 1f;
    }

    public void StopMove()
    {
        _moveDirection = 0f;
    }
}
