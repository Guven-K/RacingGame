using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FirstPos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject positionDis;

     void OnTriggerExit(Collider other)
    {
        if (other.tag == "CarPosition")
        {
            positionDis.GetComponent<TMPro.TextMeshProUGUI>().text = "1st";

        }
    }
}
