using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] private string playerId;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision && playerId == "1")
        {
            GameEventBus.RaisePlayerScoreAPoint(playerId);
            SceneManager.LoadScene(0);
        }

        if (collision && playerId == "2")
        {
            GameEventBus.RaisePlayerScoreAPoint(playerId);
            SceneManager.LoadScene(0);
        }
    }
}
