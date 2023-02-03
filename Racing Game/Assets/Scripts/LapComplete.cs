using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapComplete : MonoBehaviour
{
    // Seting a public variable 
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilDisplay;

    public GameObject LapTimeBox;

    // When the player touches the Lap it will display their best time. 
    private void OnTriggerEnter()
    {
     // Gets the compoment from LapTimer and then saves it 
        if (LapTimeManager.SecondCount <= 9)
        {
            SecDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapTimeManager.SecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else
        {
            MinDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapTimeManager.MinuteCount + ".";
        }

        // Added ToString to fix Milliseconds count.
        MilDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapTimeManager.MilliCount.ToString("F0");

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

        // Enables Half Trigger object and disables LapCompleteTrigger
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);

    }
}
