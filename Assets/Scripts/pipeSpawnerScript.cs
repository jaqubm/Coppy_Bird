using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public coppyBird_Movement bird;
    public gameLogic logic;

    public float maxHeight;
    
    private float timer;
    
    void Start()
    {
        timer = 0;
        
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<coppyBird_Movement>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>();

        spawnPipe();
    }
    
    void Update()
    {
        if (bird.birdIsAlive)
        {
            if (timer < logic.spawnRate)
                timer += Time.deltaTime;
            else
            {
                spawnPipe();
                timer = 0;
            }
        }
    }

    void spawnPipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-maxHeight, maxHeight), transform.position.z), transform.rotation);
    }
}
