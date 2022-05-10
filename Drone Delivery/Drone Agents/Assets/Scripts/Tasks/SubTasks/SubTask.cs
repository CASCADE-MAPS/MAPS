using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//[CreateAssetMenu(fileName = "SubTask", menuName = "Task Objects/New Sub Task", order = 1)]
[System.Serializable]
public abstract class SubTask
{
    // I'm using an abstract class here so that I can generically call the
    // current sub task of a task from the agent's script without needing to
    // check what the sub task is

    public UnityEvent OnSubTaskComplete_Event = new UnityEvent();

    public virtual void DoSubTask(Controller controller)
    {
        /* The logic for the sub task will be implemented here
        * Each sub task and controller will need to share functions
        * For example: A controller will have a MoveToTarget function
        * which is needed for a sub task such as "MoveToDestination"
        */
    }
}
