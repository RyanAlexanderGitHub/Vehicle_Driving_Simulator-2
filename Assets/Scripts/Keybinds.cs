using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This script controls the pausing and slow-mo for the game
*/
public class Keybinds : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && Time.timeScale != 0f) // Pause
        {
            Time.timeScale = 0f;
        }
        else if (Input.GetKeyDown(KeyCode.O) && Time.timeScale != 0.5f) // Slow-mo
        {
            Time.timeScale = 0.5f;
        }
        else if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.O)) // Play
        {
            Time.timeScale = 1f;
        }
    }
}
