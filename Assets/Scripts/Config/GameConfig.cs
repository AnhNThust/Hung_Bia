using UnityEngine;

[CreateAssetMenu(fileName ="GameConfig", menuName ="Game/Config")]
public class GameConfig : ScriptableObject
{
    public float beerSpeed = 3f;
    public float catcherSpeed = 3f;
    public int catcherLife = 3;

    // Limit Move on Mobile
    public float leftLimit = -2.1f;
    public float rightLimit = 2.1f;
}
