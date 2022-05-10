using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverySource : MonoBehaviour
{

    // Really, I don't think this needs to be a class - the sources
    // are simply the place the delivery starts and no other info
    // needs including in that fact

    /*  The delivery source class is used to represent depots
     *  and warehouses, any kind of place where a delivery job
     *  would originate. Each source comes with its own fleet
     *  of drones "ooohhhh" - so there should be a specific
     *  task manager for each source? This sounds awkward...
     */

    // Task manager and destinations served by this source
    TaskManager manager;
    DeliveryDestination[] destinations;

    // How many drones are available to this source
    public int droneFleetSize;

    // We could look at the demands of all destinations, distances
    // and drone speeds to approximate how many drones would be
    // required to properly meet the needs of the destinations
    // This would not account for other delivery sources...
    int expectedDroneFleetSize;

    // This flag could be helpful when multiple sources feed
    // a single destination, thus the destination can request
    // delivery from the nearest available source
    public bool hasDroneAvailable;


    // Start is called before the first frame update
    void Start()
    {
        if (destinations == null || destinations.Length == 0)
        {
            Debug.LogWarning("Delivery source on " + gameObject.name + " has no destinations assigned.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // I think it would be cool to see a web of all the delivery connections!
    private void OnDrawGizmos()
    {
        if (destinations != null && destinations.Length != 0)
        {
            for (int i = 0; i < destinations.Length; i++)
            {
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(transform.position, destinations[i].transform.position);
            }
        }
    }
}
