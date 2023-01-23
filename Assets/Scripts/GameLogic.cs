using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public int points;
    
    public float pipeSpawnTime;
    public float pipeMovementSpeed;
    public float pipeDeadZone;

    void Start()
    {
        points = 0;
    }
}
