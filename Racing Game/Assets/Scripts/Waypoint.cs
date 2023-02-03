using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {

    // The start waypoint, this is initialized in Awake.
    // This variable is static thus all instances of the waypoint script share it.
    static Waypoint start;

    // The next waypoint, this variable needs to be assigned in the inspector.
    // You can select all waypoints to see the full waypoint path.
    public Waypoint next;

    private Transform tr;

    // This determines where the start waypoint is.
    public bool isStart = false;

    // This initializes the start and goal static variables.
    // We have to inside Awake because the waypoints need to be initialized before the AI scripts use it
    // All Awake function are always called before all start functions.
    void Awake()
    {
        tr = GetComponent<Transform>();

        if (!next)
            Debug.Log("This waypoint is not connected, you need to set the next waypoint!", this);
        if (isStart)
            start = this;
    }

    // Returns where the AI should drive towards. The position is the current position of the car.
    Vector3 CalculateTargetPosition(Vector3 position) 
    {
        // If it's getting close to the waypoint, it returns the next waypoint.
        // This gives a better car behaviour when cars don’t exactly hit the waypoint
        if (Vector3.Distance(transform.position, position) < 6) 
        {
            return next.transform.position;
        }

        else
        {
            return tr.position;
        }
    }

    // Draws  the waypoint lines only when one of the waypoints is selected
    void OnDrawGizmos()
    {
        if (next)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, next.transform.
            position);

        }
    }
}
