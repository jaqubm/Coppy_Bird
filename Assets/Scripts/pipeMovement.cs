using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour
{
    public coppyBird_Movement bird;
    public gameLogic logic;
    
    public float deadZone = -50;
    
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<coppyBird_Movement>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>();
    }
    
    void Update()
    {
        if(bird.birdIsAlive)
               transform.position += (Vector3.left * logic.moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
            Destroy(gameObject);
    }
}
