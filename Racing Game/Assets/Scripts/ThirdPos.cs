using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThirdPos : MonoBehaviour
{

    public GameObject positionDis;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "CarPosition")
        {
            // Updates the PositionDisplay text to 3rd
            positionDis.GetComponent<TMPro.TextMeshProUGUI>().text = "3rd";

        }
    }

}