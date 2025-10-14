using System;
using UnityEngine;

public static class GameEventBus
{
    // === Player scores a point ===

    public static event Action<string> OnPlayerScoreAPoint;
    public static void RaisePlayerScoreAPoint(string playerId)
    {
        OnPlayerScoreAPoint?.Invoke(playerId);
    }   
}
