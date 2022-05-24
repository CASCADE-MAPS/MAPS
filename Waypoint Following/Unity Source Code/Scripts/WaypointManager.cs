using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    // This class is used to maintain a list of Waypoint objects and edit them in the scene

    // We should probably create a namespace for this but for the sake of
    // getting things done quickly I'm just writing this comment for now
    public bool showWaypointList = false;
    public List<Waypoint> Waypoints = new List<Waypoint>();

    [Tooltip("Displacement of new waypoint from the previous waypoint")]
    public Vector3 newWaypointOffset = new Vector3(0, 0, 5);
    [Tooltip("Displacement of new lookpoint from the new waypoint position")]
    public Vector3 newLookPointOffset = new Vector3(0, 5, 5);

    // Gizmo stats
    public float debugRadius = 1f;
    public Color pointColor = Color.green;

    // Look point gizmo stats
    [Tooltip("Toggle the look point gizmos, doesn't affect controllers using waypoints")]
    public bool useLookPoints;
    public Color lookPointColor = Color.blue;
    public Color lineColor = Color.white;
    public Color lineOfSightColor = Color.blue;
    public bool persistentGizmos = true;

    public void AddWaypoint()
    {
        Vector3 newPoint;
        Vector3 newLookPoint;

        if (Waypoints.Count == 0)
        {
            // Default to this transform's position for first waypoint
            newPoint = transform.position;
            newLookPoint = newPoint + newLookPointOffset;
        }
        else
        {
            newPoint = Waypoints[Waypoints.Count - 1].position + newWaypointOffset;
            newLookPoint = newPoint + newLookPointOffset;
        }
        Waypoints.Add(new Waypoint(newPoint, newLookPoint));
    }

    public void RemoveLastWaypoint()
    {
        int count = Waypoints.Count;
        if (count >= 1)
        {
            Waypoints.RemoveAt(count - 1);
        }
    }

    void OnDrawGizmos()
    {
        if (persistentGizmos)
        {
            int count = Waypoints.Count;
            for (int i = 0; i < count - 1; i++)
            {
                // Draw position gizmo
                Gizmos.color = pointColor;
                Gizmos.DrawCube(Waypoints[i].position, Vector3.one * debugRadius);
                Gizmos.color = lineColor;
                Gizmos.DrawLine(Waypoints[i].position, Waypoints[i + 1].position);
                if (useLookPoints)
                {
                    // Draw look point gizmo
                    Gizmos.color = lookPointColor;
                    Gizmos.DrawSphere(Waypoints[i].lookPoint, 0.5f* debugRadius);
                    Gizmos.color = lineOfSightColor;
                    Gizmos.DrawLine(Waypoints[i].position, Waypoints[i].lookPoint);
                }
            }
            if (count >= 1)
            {
                // Draw final waypoint
                Gizmos.color = pointColor;
                Gizmos.DrawCube(Waypoints[count - 1].position, Vector3.one*debugRadius);
                if (useLookPoints)
                {
                    // Draw final look point gizmo
                    Gizmos.color = lookPointColor;
                    Gizmos.DrawSphere(Waypoints[count - 1].lookPoint, 0.5f* debugRadius);
                    Gizmos.color = lineOfSightColor;
                    Gizmos.DrawLine(Waypoints[count-1].position, Waypoints[count-1].lookPoint);
                }
            }
        }
    }
}