using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class AreaRecorder : MonoBehaviour
{
    /* The plan for this script is to record every drone which enters and leaves the area
     * which is defined by the object's collider. We will need to use a dictionary for each drone
     * to ensure the drones are tracked properly in and out.
     */

    public float duration = 2f * 3600f;
    public float additionalDuration = 60f;
    public string path = "recorded drones.csv";
    bool done = false;

    public class DronePath
    {
        public float entryTime;
        public Vector3 entryPosition;
        public Vector3 exitPosition;

        public DronePath(float _entryTime, Vector3 _entryPosition)
        {
            entryTime = _entryTime;
            entryPosition = _entryPosition;
        }
    }

    private void Start()
    {

    }

    Dictionary<string, DronePath> dronePaths = new Dictionary<string, DronePath>();

    public float timer = 0f;
    private void FixedUpdate()
    {
        if (!done)
        {
            timer = Time.fixedTime;
            // Adding extra time here so that tracked drones are not still inside the area
            if (timer >= duration + additionalDuration)
            {
                EndMeasurements();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Only adding new drones within the regular duration
        if (timer <= duration)
        {
            string name = other.gameObject.name;

            while (dronePaths.ContainsKey(name))
            {
                name = name + "1";
            }
            dronePaths[name] = new DronePath(Time.fixedTime, other.transform.position);
            //Debug.Log(other.gameObject.name + " detected in " + gameObject.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        string name = other.gameObject.name;
        if (dronePaths.ContainsKey(name))
        {
            dronePaths[name].exitPosition = other.transform.position;
            //Debug.Log(other.gameObject.name + " exited " + gameObject.name);
        }
    }

    void EndMeasurements()
    {
        File.Delete(path);
        File.AppendAllText(path, "entry time,entry position x,entry position y,entry position z,exit position x,exit position y,exit position z\n");
        foreach (var keyValuePair in dronePaths)
        {
            DronePath dronePath = keyValuePair.Value;
            File.AppendAllText(path, dronePath.entryTime.ToString("F4")
                            + ',' + dronePath.entryPosition.x.ToString("F4") + ',' + dronePath.entryPosition.y.ToString("F4") + ',' + dronePath.entryPosition.z.ToString("F4")
                            + ',' + dronePath.exitPosition.x.ToString("F4") + ',' + dronePath.exitPosition.y.ToString("F4") + ',' + dronePath.exitPosition.z.ToString("F4") + '\n');
        }
        Debug.Log("Data saved.");
        Debug.Log(dronePaths.Count.ToString() + " drones passed through the area.");
        done = true;

        Debug.Break();
    }
}
