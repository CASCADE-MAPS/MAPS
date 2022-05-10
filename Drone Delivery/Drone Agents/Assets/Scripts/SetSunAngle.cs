using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSunAngle : MonoBehaviour
{
    public Transform sun;

    private void Start()
    {
        if (!sun)
        {
            sun = transform;
        }
        SetSun();
    }

    void SetSun()
    {
        int currentHour = System.DateTime.Now.Hour;
        Debug.Log("Current hour is " + currentHour.ToString());
        if (sun)
        {
            sun.rotation = Quaternion.Euler((70.73f / 2f) * Mathf.Sin((Mathf.PI / 12f) * (currentHour - 7f)) - 22.115f, 15f * currentHour - 28.26f, 0);
        }
    }
}
