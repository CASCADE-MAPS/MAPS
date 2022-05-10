using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float maxSpeed = 5f;
    public Agent agent;
    // Controller is an abstract class which can be anything from
    //  - Kinematics
    //  - NavAgent
    //  - A* Agent
    //    etc.

    // Used for general travelling parts of tasks
    public virtual bool MoveToTarget(Vector3 target)
    {
        Vector3 heading = (target - transform.position).normalized;
        transform.Translate(heading * maxSpeed * Time.fixedDeltaTime, Space.World);
        //transform.position = transform.position + (heading * maxSpeed * Time.fixedDeltaTime);
        transform.forward = heading;

        if (Vector3.Distance(transform.position, target) <= 0.5f)
        {
            agent.FinishSubTask();
            return true;
        }
        return false;
    }

    // Used to pick up an object
    public virtual void CollectAsset(GameObject asset)
    {
        asset.transform.parent = transform;
        agent.FinishSubTask();
    }

    // Used to deliver an object
    public virtual void DepositAsset(GameObject asset)
    {
        asset.transform.parent = null;
        Destroy(asset);
        agent.FinishSubTask();
    }
}
