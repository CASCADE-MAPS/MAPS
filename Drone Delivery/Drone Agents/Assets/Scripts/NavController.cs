using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavController : Controller
{
    NavMeshAgent navAgent;
    public Vector3 currentTarget;
    // Start is called before the first frame update
    void OnEnable()
    {
        navAgent = GetComponent<NavMeshAgent>();
        if(navAgent == null)
        {
            Debug.LogWarning("No nav agent found for NavController " + gameObject.name + ". Adding default NavMeshAgent");
            navAgent = gameObject.AddComponent<NavMeshAgent>();
        }
    }

    public override bool MoveToTarget(Vector3 target)
    {
        currentTarget = target;
        if (!navAgent.hasPath)
        {
            NavMeshPath path = new NavMeshPath();
            if (NavMesh.CalculatePath(transform.position, target, NavMesh.AllAreas, path))
            {
                navAgent.path = path;
            }
            else
            {
                Debug.LogError("Path not found for agent: " + gameObject.name);
            }
        }

        if (Vector3.Distance(transform.position, target) <= 0.5f)
        {
            //Debug.Log("Clearing path");
            navAgent.ResetPath();
            agent.FinishSubTask();
            return true;
        }
        return false;
    }

}
