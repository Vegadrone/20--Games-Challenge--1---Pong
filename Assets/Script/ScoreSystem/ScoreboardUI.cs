using UnityEngine;
using TMPro;

public class ScoreboardUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreboardUIText;
    private int player1Score = ScoreKeeper.Instance.GetPlayer1Score();
    private int player2Score = ScoreKeeper.Instance.GetPlayer2Score();

    
    void Update()
    {
        scoreboardUIText.text = $"{player1Score} - {player2Score}";
    }
}
