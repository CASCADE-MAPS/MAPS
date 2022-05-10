using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    Agent agent;
    public GameObject bLight;
    public GameObject rLight;
    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<Agent>();
        bLight.SetActive(false);
        rLight.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (agent.hasTask)
        {
            bLight.SetActive(true);
            rLight.SetActive(true);
        }
    }
}
