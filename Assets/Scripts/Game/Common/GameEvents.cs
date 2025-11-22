
using System;

public static class GameEvents
{
    public static event Action OnPlayerCatched;

    public static event Action OnPlayerDeath;

    public static event Action<int> OnScoreChange;

    public static event Action<int> OnLifeChange;

    public static void PlayerCatched()
    {
        OnPlayerCatched?.Invoke();
    }

    public static void PlayerDeath()
    {
        OnPlayerDeath?.Invoke();
    }

    public static void ScoreChange(int score)
    {
        OnScoreChange?.Invoke(score);
    }

    public static void LifeChange(int life)
    {
        OnLifeChange?.Invoke(life);
    }
}
