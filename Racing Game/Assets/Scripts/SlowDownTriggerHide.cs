using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowDownTriggerHide : MonoBehaviour
{

    public Canvas TextToHide;

    void Start()
    {    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Disables the SlowDownText  
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TextToHide.enabled = false;

            // Debug log was used to check if the SlowDownText is set to false
            Debug.Log("The message has been disappeared");
        }

    }
}
