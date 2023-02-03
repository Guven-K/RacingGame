using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapTimeManager : MonoBehaviour
{
	// Setting Variable Types for the lap timer 
	public static int MinuteCount;
	public static int SecondCount;
	public static float MilliCount;
	public static string MilliDisplay;

	public GameObject MinuteBox;
	public GameObject SecondBox;
	public GameObject MilliBox;


	void Update()
	{
		
		// Converts the MiliSeconds count into a string.
		// This mainly is to fix miliseconds display count 
		MilliCount += Time.deltaTime * 10;
		MilliDisplay = Mathf.Floor(MilliCount).ToString("F0");
		MilliBox.GetComponent<TMPro.TextMeshProUGUI>().text = "" + MilliDisplay;

		// Creates a timer and displays in a text box
		if (MilliCount >= 10)
		{
			MilliCount -= 10;
			SecondCount += 1;
		}

		if (SecondCount <= 9)
		{
			SecondBox.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + SecondCount + ".";
		}
		else
		{
			SecondBox.GetComponent<TMPro.TextMeshProUGUI>().text = "" + SecondCount + ".";
		}

		if (SecondCount >= 60)
		{
			SecondCount = 0;
			MinuteCount += 1;
		}

		if (MinuteCount <= 9)
		{
			MinuteBox.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + MinuteCount + ":";
		}
		else
		{
			MinuteBox.GetComponent<TMPro.TextMeshProUGUI>().text = "" + MinuteCount + ":";
		}
	}
}