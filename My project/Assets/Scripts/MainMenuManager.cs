using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string _gameScene;

    public void StartGame()
    {
        // Load the Loading scene
        SceneManager.LoadScene("Loading");

        // If you need to store the target game scene name for later use in the Loading scene,
        // you can set it here. For instance, using PlayerPrefs or a static variable.
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}

