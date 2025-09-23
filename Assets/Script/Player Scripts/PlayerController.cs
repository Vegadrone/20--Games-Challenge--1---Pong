using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    Rigidbody2D myRb;

    private void Awake()
    {
        myRb = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate()
    {
        PaddleMovement();
    }

    private void PaddleMovement()
    {
        float moveY = 0;

        if (Keyboard.current.wKey.isPressed)
        {
            moveY = 1;
        }

        else if (Keyboard.current.sKey.isPressed)
        {
            moveY = -1;
        }

        Vector2 moveDirection = new Vector2(0, moveY).normalized;
        myRb.linearVelocity = moveDirection * speed;
    }
}
