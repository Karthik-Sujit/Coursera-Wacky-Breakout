using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
/// <summary>
/// paddle behaviour script
/// </summary>
public class Paddle : MonoBehaviour
{
    Rigidbody2D PaddleRB;
    BoxCollider2D bc2d;
    float paddleVelocity;
    float paddleColliderHalf;
    // Start is called before the first frame update
    void Start()
    {
        PaddleRB = gameObject.GetComponent<Rigidbody2D>();
        paddleVelocity = ConfigurationUtils.PaddleMoveUnitsPerSecond;
        bc2d = gameObject.GetComponent<BoxCollider2D>();
        paddleColliderHalf = bc2d.size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Physics Updates happen this frequently
    public void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float possibleX = transform.position.x + paddleVelocity * horizontal;
        float returnX = calculateClampedX(possibleX, horizontal);
        Vector2 newPosition = new Vector2(returnX, transform.position.y);
        PaddleRB.MovePosition(newPosition);
    }

    public float calculateClampedX(float x, float direction)
    {
        if (x - paddleColliderHalf < ScreenUtils.ScreenLeft || x + paddleColliderHalf > ScreenUtils.ScreenRight)
        {
            return transform.position.x;
        }
        else
        {
            return x;
        }
    }
}
