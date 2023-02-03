using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    public CarController cc;

    void start()
    {
        cc = gameObject.GetComponent<CarController>();
    }
    // Update is called once per frame
    void Update()
    {
        var z = UnityEditor.TransformUtils.GetInspectorRotation(gameObject.transform).z;

        // If the car flips to more 85 degee angle
        if (z > 85 || z < -85)
        {
            // Sets its position back 
            transform.rotation = Quaternion.Euler(new Vector3(0f, 91.576f, 0f));
            transform.position = new Vector3(293.5f, 0f, 89.99801f);
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);

            cc.frontLeftWheelCollider.motorTorque = 0;
            cc.frontRightWheelCollider.motorTorque = 0;
            cc.brakeForce = 3000f;
            cc.frontLeftWheelCollider.brakeTorque = 0;
            cc.frontRightWheelCollider.brakeTorque = 0;
            cc.rearLeftWheelCollider.brakeTorque = 0;
            cc.rearRightWheelCollider.brakeTorque = 0;
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().Sleep();


        }

    }
}