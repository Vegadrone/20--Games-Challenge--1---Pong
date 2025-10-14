using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] private string playerId;
    [SerializeField] private AudioClip goalSound;
    [SerializeField] private float goalVolume;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision && playerId == "1")
        {
            GameEventBus.RaisePlayerScoreAPoint(playerId);
            SoundFXManager.Instance.PlaySoundFXClip(goalSound, transform, goalVolume);
            StartCoroutine(ReloadCoroutine());

        }

        if (collision && playerId == "2")
        {
            GameEventBus.RaisePlayerScoreAPoint(playerId);
            SoundFXManager.Instance.PlaySoundFXClip(goalSound, transform, goalVolume);
            StartCoroutine(ReloadCoroutine());
        }
    }
    
    private IEnumerator ReloadCoroutine()
    {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(0);
    }
}
