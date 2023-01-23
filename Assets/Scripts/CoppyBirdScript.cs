using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoppyBirdScript : MonoBehaviour
{
    private Rigidbody2D rb2d;
    
    public bool jump;
    public float jumpPower;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            jump = true;
    }

    private void FixedUpdate()
    {
        if (jump)
        {
            rb2d.velocity = Vector2.up * jumpPower;
            jump = false;
        }
    }
}
