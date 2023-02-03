using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {

    // Sets a variable for game objects for Half Trigger and Lap Complete Trigger
    public GameObject LapCompleteT;
    public GameObject HalfLapT;
    private void OnTriggerEnter()
    {
        // Disable half trigger and sets lap complete active 
        LapCompleteT.SetActive(true);
        HalfLapT.SetActive(false);

        // Debug log is used to check if the LapCompleteTrigger is set to active during the race. 
        Debug.Log("The LapCompleteTrigger is now set to active"); 
    }
}
