using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public GameLogic logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameLogic>();
    }

    void Update()
    {
        transform.position += new Vector3(-1 * logic.pipeMovementSpeed * Time.deltaTime, 0);
        
        if (transform.position.x < logic.pipeDeadZone)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        logic.points++;
    }
}
