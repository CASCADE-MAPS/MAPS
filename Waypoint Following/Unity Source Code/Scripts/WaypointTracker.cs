using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointTracker : MonoBehaviour
{
    // This class is used to keep track of the current waypoint of an object
    // as it follows a set of waypoints defined by a WaypointManager

    public delegate void WaypointReachedDelegate();
    public WaypointReachedDelegate WaypointReachedEvent;

    #region Waypoint Tracking Internal

    // The tolerance for reaching a waypoint
    // When the object is <= requiredDistance from the target waypoint
    // we will move on to the next waypoint
    public float requiredDistance = 0.25f;

    [Tooltip("Stop getting waypoints upon reaching the end of the path")]
    public bool stopAtEnd = false;

    [Tooltip("If the waypoints create a loop, the tracker will start at the begining of the path upon reaching the end.")]
    public bool waypointsAreLoop = true;

    [Tooltip("Name of the GameObject in the scene which has the WaypointManager attached to it")]
    public string WaypointName = "Waypoint Manager";

    // The WaypointManager stores the path we want to follow
    WaypointManager waypoints;

    // Our index in the list of waypoints stored in the manager
    int currentWP = 0;

    // Used to update the current waypoint index, will be negative when moving backwards
    int direction = 1;

    // If we need to stop at the end of the path we set this to true and stop
    bool done = false;

    void Start()
    {
        // Get the waypoint manager from the scene - use a name of the object here so
        // we can have multiple sets of waypoints in the scene and differentiate between them
        waypoints = GameObject.Find(WaypointName).GetComponent<WaypointManager>();

        // Make sure we found a waypoint manager
        if (waypoints == null)
        {
            Debug.LogError("No waypoint manager found.");
        }

        // Remove this line if you are changing the behaviour of the waypoint tracking
        WaypointReachedEvent += ProceedToNextWaypoint;
    }

    void FixedUpdate()
    {
        TrackWaypoints();
    }

    public virtual void TrackWaypoints()
    {
        if (!done)
        {
            // Check how close to the target waypoint we are
            float distanceToWP = Vector3.Distance(transform.position, waypoints.Waypoints[currentWP].position);

            // If we are sufficiently close to the waypoint
            if (distanceToWP <= requiredDistance)
            {
                // Call the waypoint reached event
                WaypointReachedEvent?.Invoke();
            }
        }
    }

    public void ProceedToNextWaypoint()
    {
        // Update the target waypoint index depending on our current direction
        currentWP += direction;

        // Check if we have reached the end of the list (going both ways)
        if (currentWP >= waypoints.Waypoints.Count || currentWP < 0)
        {
            // Move the index back to where it was so we don't exceed the list's indecies
            currentWP -= direction;

            // If we want to stop at the end of the list
            if (stopAtEnd)
            {
                // Set done and this whole thing will never be called again
                done = true;    // We could also destroy the object here
            }
            // Otherwise, if the waypoints are a loop
            else if (waypointsAreLoop)
            {
                // The path already makes a loop so start at the beginning again
                currentWP = 0;
            }
            else
            {
                // Reaching here means the waypoints DO NOT make a loop
                // So we want to reverse the direction of travel
                direction = -direction;
            }
        }
    }

    #endregion

    #region Public Functions

    // These methods provide access to the current target waypoint and would
    // be used by an external controller script, such as KinematicController

    // Returns the current Waypoint class instance, this includes both position and lookpoint
    public Waypoint GetCurrentWaypointData()
    {
        return waypoints.Waypoints[currentWP];
    }

    // Returns the current Waypoint position as a Vector3
    public Vector3 GetCurrentWaypoint()
    {
        return waypoints.Waypoints[currentWP].position;
    }

    // Returns the current LookPoint position as a Vector3
    public Vector3 GetCurrentLookPoint()
    {
        return waypoints.Waypoints[currentWP].lookPoint;
    }
    #endregion
}
