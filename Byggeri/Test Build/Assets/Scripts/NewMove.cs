using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMove : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        horizontal = Input.GetAxisRaw("Horizontal"); //-1 venstre 1 højre
        vertical = Input.GetAxisRaw("Vertical"); //-1 ned 1 op
    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) // Tjek Diagonal movement
        {
            // Begræns til 70%
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
