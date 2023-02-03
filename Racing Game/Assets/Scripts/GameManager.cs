using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    // This script here is used to load scenes when the user clicks on the buttons
    
    //Loads the racetrack1 scene
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    // Loads the Menu scene
    // Used to load from GameMenu scene  
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    // Quits the application 
    public void OnApplicationQuit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
