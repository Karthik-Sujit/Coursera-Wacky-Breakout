using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// paddle behaviour
/// </summary>
public class Paddle : MonoBehaviour
{
    Rigidbody2D paddleRB;
    BoxCollider2D paddleCollider;
    float halfColliderWidth;
    float paddleVelocity = ConfigurationUtils.PaddleMoveUnitsPerSecond;


    // Start is called before the first frame update
    void Start()
    {
        paddleRB = GetComponent<Rigidbody2D>();
        paddleCollider = GetComponent<BoxCollider2D>();
        halfColliderWidth = paddleCollider.size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float oldX = transform.position.x;
        Vector2 newPos = new Vector2(oldX + horizontal * paddleVelocity, transform.position.y);
        paddleRB.MovePosition(newPos);
    }
}
