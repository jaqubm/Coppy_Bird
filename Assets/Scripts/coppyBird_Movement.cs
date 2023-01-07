using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coppyBird_Movement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Animator anim;
    public gameLogic logic;

    public float jumpPower;
    public float deadZone;
    public bool birdIsAlive = true; 
    
    void Start()
    {
        anim = GetComponent<Animator>();
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

        if (rb2d.velocity.y < -0.1)
        {
            anim.SetBool("fallTransition", true);
            anim.SetBool("jumpTransition", false);
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            anim.SetBool("fallTransition", false);
            anim.SetBool("jumpTransition", true);
            rb2d.velocity = Vector2.up * jumpPower;
        }
            
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        logic.gameOver();
        birdIsAlive = false; 
    }
}
