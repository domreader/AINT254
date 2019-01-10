using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void GoToSettings()
    {
        SceneManager.LoadScene("Go To Settings");
    }

    public void GoToGarage()
    {
        SceneManager.LoadScene("Go To Garage");
    }

    public void GoToRoad()
    {
        SceneManager.LoadScene("Go To Road");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void EndGame()
    {
        Application.Quit();
    }



}