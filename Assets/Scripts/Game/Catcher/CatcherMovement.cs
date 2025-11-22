using UnityEngine;

public class CatcherMovement : MonoBehaviour
{
    public GameConfig config;

    private float moveDirection = 0f;
    private float lLimit;
    private float rLimit;
    public float speed;

    //private float leftLimit = -2.1f;
    //private float rightLimit = 2.1f;

    private void Awake()
    {
        lLimit = config.leftLimit;
        rLimit = config.rightLimit;
        speed = config.catcherSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x += moveDirection * speed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, lLimit, rLimit);

        transform.position = pos;
    }

    // cac ham goi tu button
    public void MoveLeft()
    {

        moveDirection = -1f;
    }

    public void MoveRight()
    {
        moveDirection = 1f;
    }

    public void StopMove()
    {
        moveDirection = 0f;
    }
}
