using UnityEngine;
using TMPro;

public class ScoreboardUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreboardP1UIText;
    [SerializeField] TextMeshProUGUI scoreboardP2UIText;

    private int player1Score;
    private int player2Score;

    private void Start()
    {
        player1Score = ScoreKeeper.Instance.GetPlayer1Score();
        player2Score = ScoreKeeper.Instance.GetPlayer2Score();
    }
    
    void Update()
    {
        scoreboardP1UIText.text = $"{player1Score}";
        scoreboardP2UIText.text = $"{player2Score}";
    }
}
