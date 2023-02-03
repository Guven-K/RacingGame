using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCountActive : MonoBehaviour
{

    
    public GameObject LapTrig;

    // Sets LapTrigger Object to inactive
    void Start()
    {
        LapTrig.SetActive(false);
    }

    
    void Update()
    {
        
    }

    // If the player collides it activates the lap count 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LapTrig.SetActive(true);

            // Debug was used to check if the counter has been activated 
            Debug.Log("The Lap counter has been activated");
        }
    }
}
