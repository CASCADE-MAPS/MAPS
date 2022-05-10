using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCounter : MonoBehaviour
{
    [Tooltip("Number of time steps used to average traffic")]
    public int numTimeSteps;
    public int numSkipSteps;
    public float averageTraffic;

    int[] counts;
    int count;
    int id;
    int steps;

    TextMesh text;

    // Start is called before the first frame update
    void Start()
    {
        counts = new int[numTimeSteps];
        text = transform.GetChild(0).GetComponent<TextMesh>();
    }

    private void FixedUpdate()
    {
        steps++;
        if(steps >= numSkipSteps)
        {
            steps = 0;
            counts[id] = count;
            count = 0;
            id++;
            if (id >= numTimeSteps)
            {
                id = 0;
            }
        }

        // Get average traffic per second
        averageTraffic = counts.Sum() / (numSkipSteps*numTimeSteps*Time.fixedDeltaTime);
        text.text = averageTraffic.ToString("F2");
    }

    private void OnTriggerEnter(Collider other)
    {
        count++;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
