using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coppyBird_Movement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public gameLogic logic;

    public float jumpPower;
    public float deadZone;
    public bool birdIsAlive = true; 
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>(); 
    }
    
    void Update()
    {
        if (transform.position.y > deadZone || transform.position.y < -deadZone)
        {
            logic.gameOver();
            birdIsAlive = false;
            Destroy(gameObject);
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
            rb2d.velocity = Vector2.up * jumpPower;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        logic.gameOver();
        birdIsAlive = false; 
    }
}
