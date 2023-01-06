using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betweenPipes_Script : MonoBehaviour
{
    public gameLogic logic;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>(); 
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == 3)
            logic.levelUp();
    }
}
