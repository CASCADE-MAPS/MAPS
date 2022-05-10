using System.Collections;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFakeDrones : MonoBehaviour
{
    public Transform sun;
    public GameObject fakeDrone;
    public float duration = 2f * 3600f;
    public float additionalDuration = 60f;
    public string path = "recorded drones";
    bool done = false;
    public float timer = 90f;


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

    List<DronePath> dronePaths = new List<DronePath>();

    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;

        // Check for drones which need spawning
        if (!done && dronePaths[0].entryTime <= timer)
        {
            GameObject go = (GameObject)Instantiate(fakeDrone);
            go.transform.position = dronePaths[0].entryPosition;
            go.GetComponent<FakeDroneMove>().target = dronePaths[0].exitPosition;
            dronePaths.RemoveAt(0);
            if (dronePaths.Count <= 0)
            {
                done = true;
            }
        }

        // Adding extra time here so that tracked drones are not still inside the area
        if (timer >= duration + additionalDuration)
        {
            // Need to end the simulation here
        }
    }

    private void Start()
    {
        SetSun();
        GetDroneData();
    }

    void SetSun()
    {
        int currentHour = System.DateTime.Now.Hour;
        Debug.Log("Current hour is " + currentHour.ToString());
        sun.rotation = Quaternion.Euler((70.73f / 2f) * Mathf.Sin((Mathf.PI / 12f) * (currentHour - 7f)) - 22.115f, 15f * currentHour - 28.26f, 0);
    }

    void GetDroneData()
    {
        TextAsset allData = Resources.Load<TextAsset>(path);
        string[] lines = allData.text.Split('\n');
        // Don't forget to skip the header...
        for (int i = 1; i < lines.Length; i++)
        {
            string[] line = lines[i].Split(',');
            if (line.Length > 1)
            {
                // index 5 is the height at exit
                if (float.Parse(line[5]) != 0f)
                {
                    DronePath dp = new DronePath(float.Parse(line[0]), new Vector3(float.Parse(line[1]), float.Parse(line[2]), float.Parse(line[3])));
                    dp.exitPosition = new Vector3(float.Parse(line[4]), float.Parse(line[5]), float.Parse(line[6]));
                    dronePaths.Add(dp);
                }
            }
        }

        // Sort ascending entry times so we don't have to search the list over and over
        dronePaths = dronePaths.OrderBy(o => o.entryTime).ToList();

        int removeRange = -1;
        for (int i = 0; i < dronePaths.Count; i++)
        {
            // Only spawning drones that should already be in the scene
            if (dronePaths[i].entryTime > timer)
                break;

            
            // How far the drone will travel from start to end
            float distToTarget = Vector3.Distance(dronePaths[i].entryPosition, dronePaths[i].exitPosition);

            // How far the drone would travel given the time it's been flying (speed * time)
            float distTravelledSinceSpawn = FakeDroneMove.speed * (timer - dronePaths[i].entryTime);

            // If the drone would have travelled past the target position we don't want to spawn it in
            if (distTravelledSinceSpawn >= distToTarget)
            {
                // Still need to remove them from the list though!
                removeRange = i;
                continue;
            }

            GameObject go = (GameObject)Instantiate(fakeDrone);
            go.GetComponent<FakeDroneMove>().target = dronePaths[i].exitPosition;

            // Lerp the motion so that we don't have to wait for all drones to spawn at the bounds of the area
            go.transform.position = dronePaths[i].entryPosition + FakeDroneMove.speed * (timer - dronePaths[i].entryTime) * (dronePaths[i].exitPosition - dronePaths[i].entryPosition).normalized;

            removeRange = i;
        }

        if (removeRange >= 0)
        {
            dronePaths.RemoveRange(0, removeRange + 1);
        }

        Debug.Log(dronePaths[0].entryTime);
        Debug.Log(dronePaths[dronePaths.Count-1].entryTime);
    }
}


