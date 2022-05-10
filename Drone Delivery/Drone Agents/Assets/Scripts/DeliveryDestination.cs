using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryDestination : MonoBehaviour
{

    /*  The delivery destination class is used as the customer
     *  or business etc. which receives deliveries. The destination
     *  has a demand model which determines when it will next request
     *  a delivery to be made. The destination may also manage which
     *  delivery source to request a job from, depending on proximity
     *  and availability - maybe! This could become too much...
     */

    // For now, the manager acts like the company which handles deliveries e.g. amazon or deliveroo
    public FleetManager manager;

    // Deliveries are requested ever X seconds
    public float requestRate;

    [Tooltip("After making a delivery request this component disables itself")]
    public bool oneShotRequest;
    float requestTimer;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        requestTimer = Time.fixedTime;
        if(requestTimer >= requestRate)
        {
            manager.MakeDeliveryRequest(transform);
            
            requestTimer -= requestRate;

            if (oneShotRequest)
            {
                gameObject.SetActive(false);
            }
        }
    }

    //private void OnDrawGizmos()
    //{
    //    if (manager)
    //    {
    //        Vector3 pos = transform.position;
    //        // Drawing lines between this destination and all of the sources which supply it
    //        for (int i = 0; i < manager.sources.Length; i++)
    //        {
    //            Gizmos.DrawLine(pos, manager.sources[i].transform.position);
    //        }
    //    }
    //}
}
