using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper Instance { get; private set; }

    private int player1Score;
    private int player2Score;
   
    private void OnEnable()
    {
        GameEventBus.OnPlayerScoreAPoint += OnPlayerScoreAPoint;
    }

    private void OnDisable()
    {
        GameEventBus.OnPlayerScoreAPoint -= OnPlayerScoreAPoint;
    }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        player1Score = 0;
        player2Score = 0;

    }

    private void OnPlayerScoreAPoint(string playerId)
    {
        if (playerId == "1")
        {
            player2Score++;
            Debug.Log($"<color=green>Player 2 score {player2Score} points!</color>");
        }
        if (playerId == "2")
        {
            player1Score++;
            Debug.Log($"<color=yellow>Player 1 score{player1Score} points!</color>");
        }
    }

    public int GetPlayer1Score()
    {
        return player1Score;
    }

    public int GetPlayer2Score()
    {
        return player2Score;
    }
}
