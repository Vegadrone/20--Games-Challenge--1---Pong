using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float tolerance = 0.2f;
    [SerializeField] private BallMovement ballMovement;    
    Rigidbody2D myRb;
    private Vector2 restPos;

    void Awake()
    {
        myRb = GetComponent<Rigidbody2D>();
        restPos = transform.position;
    }
    void FixedUpdate()
    {
        EnemyMovement();
    }

    // private void PlayerMovement()
    // {
      
    //     float moveY = 0f;

    //     if (Keyboard.current.upArrowKey.isPressed)
    //     {
    //         moveY = 1f;
    //     }
    //     else if (Keyboard.current.downArrowKey.isPressed)
    //     {
    //         moveY = -1f;
    //     }

    //     Vector2 moveDirection = new Vector2(0, moveY).normalized;
    //     myRb.linearVelocity = moveDirection * speed;
    // }
    
    private void EnemyMovement()
    {
        Vector2 targetDirection;

        if (ballMovement.GetBallPosition().x > 0)
        {
            targetDirection = ballMovement.GetBallPosition();

        }
        else
        {
            targetDirection = restPos;
        }

        if (MathF.Abs(targetDirection.y - transform.position.y) < tolerance)
        {
            myRb.linearVelocity = Vector2.zero;
        }
        else
        {
            Vector2 moveDirection = new Vector2(0, targetDirection.y - transform.position.y).normalized;
            myRb.linearVelocity = moveDirection * speed;
        }
    
    }
}
