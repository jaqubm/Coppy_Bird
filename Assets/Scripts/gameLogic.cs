using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameLogic : MonoBehaviour
{
    public Text levelText;
    public GameObject gameOverScreen;
    public pipeSpawnerScript spawner;

    public int gameLevel;
    public int moveSpeed;
    public double spawnRate;
    public float deadZone = -5;

    private void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<pipeSpawnerScript>();
    }

    [ContextMenu("Increase Level")]
    public void levelUp()
    {
        gameLevel++;
        levelText.text = gameLevel.ToString();

        if (gameLevel != 0)
        {
            if (gameLevel % 3 == 0)
            {
                moveSpeed += 2;
                spawnRate -= 0.1;
            }

            Debug.Log("moveSpeed: " + moveSpeed);
            Debug.Log("spawnRate: " + spawnRate);
        }
    }

    public void gameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
         gameOverScreen.SetActive(true); 
    }
}
