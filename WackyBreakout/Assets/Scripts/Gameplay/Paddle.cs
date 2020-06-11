using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Jobs;
/// <summary>
/// paddle behaviour script
/// </summary>
public class Paddle : MonoBehaviour
{
    Rigidbody2D PaddleRB;
    BoxCollider2D bc2d;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D PaddleRB = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
        float paddleColliderHalf = bc2d.size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Physics Updates happen this frequently
    public void FixedUpdate()
    {
        
    }

    public float calculateClampedX(float x)
    {
        if (x - paddleColliderHalf < ScreenUtils.ScreenLeft || x + paddleColliderHalf > ScreenUtils.ScreenRight)
        {
            return x;
        }
        else
        {
            return transform.position.x;
        }
    }
}
