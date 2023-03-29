using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinballController : MonoBehaviour
{
    public float ballSpeed = 100f;
    public Rigidbody2D ball;

    private bool ballInPlay;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !ballInPlay)
        {
            ball.transform.parent = null;
            ballInPlay = true;
            ball.AddForce(new Vector3(0f, 0f, ballSpeed));
        }
    }
}

