using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] float speed = 10;
    Rigidbody2D myRb;

    void Awake()
    {
        myRb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
      
        float moveY = 0f;

        if (Keyboard.current.upArrowKey.isPressed)
        {
            moveY = 1f;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            moveY = -1f;
        }

        Vector2 moveDirection = new Vector2(0, moveY).normalized;
        myRb.linearVelocity = moveDirection * speed;
    }
}
