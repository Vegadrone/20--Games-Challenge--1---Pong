using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float startSpeed = 0f;
    [SerializeField] private float maxSpeed = 10f;
    private Vector2 ballPosition;
    private float ballSpeed;

    Rigidbody2D ballRb;

    private void Awake()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ballPosition = transform.position;
        ballSpeed = ballRb.linearVelocity.magnitude;
    }

    private void Start()
    {
        LaunchTheBall();
    }

    private void FixedUpdate()
    {
        if (ballRb.linearVelocity.magnitude > maxSpeed)
        {
            ballRb.linearVelocity =  ballRb.linearVelocity.normalized * maxSpeed;
        }
    }

    private void LaunchTheBall()
    {
        Vector2 moveDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        ballRb.linearVelocity = moveDirection.normalized * startSpeed;
    }

    public Vector2 GetBallPosition() => ballPosition;
    public float GetBallSpeed() => ballSpeed;
    
}
