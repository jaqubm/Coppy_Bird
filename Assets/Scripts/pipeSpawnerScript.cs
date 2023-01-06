using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public coppyBird_Movement bird;

    public float maxHeight;

    public double spawnRate = 2;
    private float timer = 0;
    
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<coppyBird_Movement>();

        spawnPipe();
    }
    
    void Update()
    {
        if (bird.birdIsAlive)
        {
            if (timer < spawnRate)
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
