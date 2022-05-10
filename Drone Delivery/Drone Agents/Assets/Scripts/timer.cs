using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time = Time.fixedTime;
    }
}
