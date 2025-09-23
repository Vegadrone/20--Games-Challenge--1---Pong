using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0;

    Rigidbody2D ballRb;

    private void Awake()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        AddingForceToBall();
    }

    private void AddingForceToBall()
    {
        Vector2 moveDirection = new Vector2(1, 1);
        ballRb.AddForce(moveDirection * speed);
    }
}
