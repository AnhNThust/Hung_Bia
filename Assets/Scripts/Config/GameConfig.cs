using UnityEngine;

[CreateAssetMenu(fileName ="GameConfig", menuName ="Game/Config")]
public class GameConfig : ScriptableObject
{
    // Player
    public float BeerSpeed = 3f;
    public float CatcherSpeed = 3f;
    public int CatcherLife = 3;

    // Spawner
    public float SpLLimit = -2.2f;
    public float SpRLimit = 2.2f;
    public float CoolDown = 1f;

    // Catcher Limit Move on Mobile
    public float MovLLimit = -2.1f;
    public float MovRLimit = 2.1f;
}
