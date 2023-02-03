using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro; 

public class LapCount : MonoBehaviour
{
    // Setting the variables 
    public TextMeshProUGUI LapCounterText;
    public float LapCounter = -1;


   
    void Start()
    {
        LapCounterText.text = LapCounter.ToString();
    }

    // If the player completes two laps, it will load GameEnd scene
    void Update()
    {
        if (LapCounter == 2)
        {
            SceneManager.LoadScene(2);
        }
    }

    // If the player touches lap counter trig object the count goes up
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            LapCounter = LapCounter + 1;
            LapCounterText.text = LapCounter.ToString();
        }
    }
}
