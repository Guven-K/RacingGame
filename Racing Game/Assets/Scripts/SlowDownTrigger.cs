using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SlowDownTrigger : MonoBehaviour
{

    public Canvas TextToShow; 

    void Start()
    {
        TextToShow.enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            TextToShow.enabled = true;

            // Debug log was used to check if the SlowDownText is set to true
            Debug.Log("The message has been triggered");
        }

    }
}
