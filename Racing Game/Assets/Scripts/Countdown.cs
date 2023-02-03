using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public GameObject LapTimer;
    public CarController CarControl;
    public AIVehicle AIControl;
    public AIVehicle2 AIYellow;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (CountStart ());

        // Disables the car controller and both ai control scripts
        CarControl.GetComponent<CarController>().enabled = false;
        AIControl.GetComponent<AIVehicle>().enabled = false;
        AIYellow.GetComponent<AIVehicle2>().enabled = false;

    }

    // This initiates countdown process 
    IEnumerator CountStart ()
    {
        // Waits for half a second
        yield return new WaitForSeconds (0.5f);
        // Sets component to three
        CountDown.GetComponent<TMPro.TextMeshProUGUI> ().text = "3";
        CountDown.SetActive (true);

        // Waits for a second
        // Sets the component to two 
        yield return new WaitForSeconds (1);
        CountDown.SetActive (false);
        CountDown.GetComponent<TMPro.TextMeshProUGUI> ().text = "2";
        CountDown.SetActive (true);

        // Waits for a second
        // Sets the component to one
        yield return new WaitForSeconds (1);
        CountDown.SetActive (false);
        CountDown.GetComponent<TMPro.TextMeshProUGUI> ().text = "1";
        CountDown.SetActive (true);

        
        // Waits for another second
        // Sets the component to "GO!"
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<TMPro.TextMeshProUGUI>().text = "GO!";
        CountDown.SetActive(true);

        // Enables the car controller and both AI control after the countdown process
        CarControl.GetComponent<CarController>().enabled = true;
        AIControl.GetComponent<AIVehicle>().enabled = true;
        AIYellow.GetComponent<AIVehicle2>().enabled = true;

        // Enables the lap timer and then disables the countdown 
        LapTimer.SetActive(true);
        yield return new WaitForSeconds (1);
        CountDown.SetActive (false);
    }
   
}
