using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    // Start is called before the first frame update
  
    void Start()
    {

    }

    
    // Update is called once per frame
    void Update()
    {
        // When K is pressed it takes a screenshot
        if (Input.GetKeyDown(KeyCode.K))
        {
            // Takes a screenshots and saves it in png format. Also Increases the resolution by twice
            ScreenCapture.CaptureScreenshot("screenshotSample.png", 2);
        }
    }
}