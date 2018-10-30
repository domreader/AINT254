﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public void StartGame()
    {

        SceneManager.LoadScene("Level 1");

    }

    public void EndGame()
    {

        SceneManager.LoadScene("Game Over");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void EndApplication()
    {
        Application.Quit();
    }

}
