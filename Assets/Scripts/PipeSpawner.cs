using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameLogic logic;
    public GameObject pipe;

    public float counter = 0f;
    
    void Update()
    {
        if (counter < logic.pipeSpawnTime)
            counter += Time.deltaTime;
        else
        {
            Instantiate(pipe, transform.position, new Quaternion(0, 0, 0, 0));
            counter = 0;
        }
    }
}
