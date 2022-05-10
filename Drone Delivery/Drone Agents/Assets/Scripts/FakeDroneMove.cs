using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeDroneMove : MonoBehaviour
{
    public static float speed = 10f;
    public Vector3 target;
    Vector3 moveDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetMyHeight();

        moveDir = (target - transform.position).normalized;
        transform.position = transform.position + Time.fixedDeltaTime * speed * moveDir;
        transform.forward = moveDir;
        if(Vector3.Distance(target,transform.position) < 1f)
        {
            Destroy(gameObject);
        }
    }

    private void SetMyHeight()
    {
        transform.position = new Vector3(transform.position.x, DroneHeightSetter.DroneHeight, transform.position.z);
        target.y = DroneHeightSetter.DroneHeight;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, 5f);
    }
}
