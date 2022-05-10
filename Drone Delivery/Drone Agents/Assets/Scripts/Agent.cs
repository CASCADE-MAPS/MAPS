using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    // Indicator if the agent is currently assigned a task
    public bool hasTask = false;

    // Indicator if the agent is docked or travelling
    public bool docked = false;

    public Vector3 hangarPosition;

    // The current task of the agent
    Task currentTask;

    // The controller of the agent
    Controller controller;

    // Using a base manager class here so that we can add further logic on top by inheriting
    // from the base manager class
    BaseManager manager;


    void OnEnable()
    {
        controller = GetComponent<Controller>();
        if(controller == null)
        {
            Debug.LogWarning("No controller found, adding default controller to " + gameObject.name);
            gameObject.AddComponent<Controller>();
        }
        controller.agent = this;
    }

    // FixedUpdate is called every fixed time step (dt)
    void FixedUpdate()
    {
        // Using a bool to check this rather than comparing with null every step
        if (hasTask)
        {
            // This feels wrong, I want the syntaxt to be controller.DoSubTask(subtask)
            // but then there would need to be a switch statement to determine which subtask it is
            currentTask.CurrentSubTask().DoSubTask(controller);
        } else if(!docked)
        {
            docked = controller.MoveToTarget(hangarPosition);
        }
    }

    // Give the agent a task to complete
    public void AssignTask(Task _newTask)
    {
        docked = false;
        currentTask = _newTask;
        hasTask = true;
        currentTask.OnTaskComplete_Event.AddListener(MakeAvailable);
    }

    public void FinishSubTask()
    {
        if (hasTask)
        {
            // This feels a bit convoluted but there may be other things listening to the event!
            currentTask.CurrentSubTask().OnSubTaskComplete_Event.Invoke();
        }
    }

    void MakeAvailable()
    {
        hasTask = false;
        manager.AddAvailableAgent(this);
    }

    public void GiveManager(BaseManager _manager)
    {
        manager = _manager;
    }
}
