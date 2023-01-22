using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoppyBirdScript : MonoBehaviour
{
    private Rigidbody2D rb2d;
    
    public bool jumpFunc;
    public float jumpPower;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            jumpFunc = true;
    }

    private void FixedUpdate()
    {
        if (jumpFunc)
        {
            rb2d.velocity = Vector2.up * jumpPower;
            jumpFunc = false;
        }
    }
}
