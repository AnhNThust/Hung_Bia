using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "Game/Data")]
public class GameData : ScriptableObject
{
    public int currentScore;
    public int highScore;

    public void ResetData()
    {
        currentScore = 0;
    }
}
