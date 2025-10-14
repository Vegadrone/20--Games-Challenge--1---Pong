using UnityEngine;

public class BallCollider : MonoBehaviour
{
    [SerializeField] private float repulsionForce = 10f;
    [SerializeField] private float speed = 10f;
    [SerializeField] private AudioClip collisionFXClip;
    [SerializeField] private float collisionFXClipVolume = 1f;
    private string collisionTag = "Collision";

    Rigidbody2D ballRb;

    private void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(collisionTag))
        {
            Vector2 repulsionDirection = (transform.position - collision.transform.position).normalized;

            ballRb.AddForce(repulsionDirection * repulsionForce, ForceMode2D.Impulse);
            collision.rigidbody.AddForce(-repulsionDirection * repulsionForce, ForceMode2D.Impulse);
        }
        SoundFXManager.Instance.PlaySoundFXClip(collisionFXClip, transform, collisionFXClipVolume);
    }
}
