using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CustomEditor(typeof(WaypointManager))]
public class WaypointEditor : Editor
{
    Tool lastTool = Tool.None;
    void OnEnable()
    {
        lastTool = Tools.current;
        Tools.current = Tool.None;
    }

    void OnDisable()
    {
        Tools.current = lastTool;
    }

    void DrawCustomInspector()
    {
        WaypointManager wpManager = (WaypointManager)target;

        wpManager.newWaypointOffset = EditorGUILayout.Vector3Field("New Waypoint Offset", wpManager.newWaypointOffset);
        wpManager.newLookPointOffset = EditorGUILayout.Vector3Field("New LookPoint Offset", wpManager.newLookPointOffset);

        // Waypoint gizmos
        wpManager.debugRadius = EditorGUILayout.FloatField("Gizmo Size", wpManager.debugRadius);
        wpManager.pointColor = EditorGUILayout.ColorField("Waypoint Colour", wpManager.pointColor);
        wpManager.lineColor = EditorGUILayout.ColorField("Waypoint Line Colour", wpManager.lineColor);

        // LookPoint gizmos
        wpManager.useLookPoints = GUILayout.Toggle(wpManager.useLookPoints, "Show LookPoints");
        if (wpManager.useLookPoints)
        {
            wpManager.lookPointColor = EditorGUILayout.ColorField("LookPoint Colour", wpManager.lookPointColor);
            wpManager.lineOfSightColor = EditorGUILayout.ColorField("LookPoint Line Colour", wpManager.lineOfSightColor);
        }

        wpManager.persistentGizmos = GUILayout.Toggle(wpManager.persistentGizmos, "Persistent Gizmos");

        wpManager.showWaypointList = GUILayout.Toggle(wpManager.showWaypointList, "Show Waypoint List");
        // Only draw the list if it's checked
        if (wpManager.showWaypointList)
        {
            int wpCount = wpManager.Waypoints.Count;
            for (int i = 0; i < wpCount; i++)
            {
                EditorGUILayout.Space();
                EditorGUILayout.LabelField("WP " + (i+1).ToString());
                wpManager.Waypoints[i].position = EditorGUILayout.Vector3Field("Position", wpManager.Waypoints[i].position);
                wpManager.Waypoints[i].lookPoint = EditorGUILayout.Vector3Field("Look Point", wpManager.Waypoints[i].lookPoint);
            }

        }
    }

    protected virtual void OnSceneGUI()
    {
        Tools.current = Tool.None;
        WaypointManager wpManager = (WaypointManager)target;

        int count = wpManager.Waypoints.Count;
        for (int i = 0; i < count - 1; i++)
        {
            if (!wpManager.persistentGizmos)
            {
                // Draw handles for waypoint positions
                Handles.color = wpManager.pointColor;
                Handles.CubeHandleCap(0, wpManager.Waypoints[i].position, Quaternion.identity, wpManager.debugRadius, EventType.Repaint);
                Handles.color = wpManager.lineColor;
                Handles.DrawLine(wpManager.Waypoints[i].position, wpManager.Waypoints[i + 1].position);

                if (wpManager.useLookPoints)
                {
                    // Draw handles for waypoint look positions
                    Handles.color = wpManager.lookPointColor;
                    Handles.SphereHandleCap(0, wpManager.Waypoints[i].lookPoint, Quaternion.identity, wpManager.debugRadius, EventType.Repaint);
                    Handles.color = wpManager.lineOfSightColor;
                    Handles.DrawLine(wpManager.Waypoints[i].position, wpManager.Waypoints[i].lookPoint);
                }
            }
            // Update positions using standard xyz position handles
            wpManager.Waypoints[i].position = Handles.PositionHandle(wpManager.Waypoints[i].position, Quaternion.identity);

            if (wpManager.useLookPoints)
            {
                // Update lookpoint positions using xyz handles
                wpManager.Waypoints[i].lookPoint = Handles.PositionHandle(wpManager.Waypoints[i].lookPoint, Quaternion.identity);
            }
        }
        if (count >= 1)
        {
            if (!wpManager.persistentGizmos)
            {
                // Draw waypoint positions
                Handles.color = wpManager.pointColor;
                Handles.CubeHandleCap(0, wpManager.Waypoints[count - 1].position, Quaternion.identity, wpManager.debugRadius, EventType.Repaint);

                if (wpManager.useLookPoints)
                {
                    // Draw lookpoints
                    Handles.color = wpManager.lookPointColor;
                    Handles.SphereHandleCap(0, wpManager.Waypoints[count - 1].lookPoint, Quaternion.identity, wpManager.debugRadius, EventType.Repaint);
                    Handles.DrawLine(wpManager.Waypoints[count-1].position, wpManager.Waypoints[count-1].lookPoint);
                }
            }
            wpManager.Waypoints[count - 1].position = Handles.PositionHandle(wpManager.Waypoints[count - 1].position, Quaternion.identity);
            if (wpManager.useLookPoints)
            {
                wpManager.Waypoints[count-1].lookPoint = Handles.PositionHandle(wpManager.Waypoints[count-1].lookPoint, Quaternion.identity);
            }
        }

    }

    public override void OnInspectorGUI()
    {
        //DrawDefaultInspector();

        DrawCustomInspector();

        WaypointManager wpManager = (WaypointManager)target;
        if (GUILayout.Button("Add Waypoint"))
        {
            wpManager.AddWaypoint();
            HandleUtility.Repaint();
            SceneView.RepaintAll();
            Repaint();
        }
        GUILayout.Space(10);
        if (GUILayout.Button("Remove Last Waypoint"))
        {
            wpManager.RemoveLastWaypoint();
            Repaint();
            HandleUtility.Repaint();
            SceneView.RepaintAll();

        }
    }
}