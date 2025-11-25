using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "Game/Data")]
public class GameData : ScriptableObject
{
    public int CurrentScore;
    public int HighScore;

    // ham reset lai diem hien tai cua nguoi choi
    public void ResetData()
    {
        CurrentScore = 0;
    }
}
