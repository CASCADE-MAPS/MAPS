using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : BaseManager
{
    /* Task manager is in charge of delegation
     * The manager needs to keep track of jobs which are waiting, in progress, and completed
     * It also needs to track the agents which are busy and those which are available
     * I think queues are a good start, priority can be added in the future if necessary
     */

    Queue<Task> TasksWaiting = new Queue<Task>();
    //List<Task> TasksInProgress = new List<Task>();
    List<Task> TasksCompleted = new List<Task>();

    Queue<Agent> AvailableAgents = new Queue<Agent>();


    // Start is called before the first frame update
    void Start()
    {
        // Add all agents in the scene to the available queue
        Agent[] allAgents = GetAllAgents();
        for (int i = 0; i < allAgents.Length; i++)
        {
            allAgents[i].GiveManager(this);
            AvailableAgents.Enqueue(allAgents[i]);
        }
    }


    // Checks if a task is waiting to be done
    // if not adds agent to available agent queue
    public override void AddAvailableAgent(Agent _newAgent)
    {
        // Check for task
        if (TasksWaiting.Count >= 1)
        {
            _newAgent.AssignTask(TasksWaiting.Dequeue());
        }
        else
        {
            AvailableAgents.Enqueue(_newAgent);
        }
    }

    // Check if an agent is free to take on new task
    // if not adds to task waiting queue
    public override void AddNewTask(Task _newTask)
    {
        // Check for available agent
        if(AvailableAgents.Count >= 1)
        {
            Agent agent = AvailableAgents.Dequeue();
            agent.AssignTask(_newTask);
            //_newTask.OnTaskComplete_Event.AddListener(CompleteTask(_newTask));
        }
        else
        {
            TasksWaiting.Enqueue(_newTask);
        }
    }

    Agent[] GetAllAgents()
    {
        return FindObjectsOfType<Agent>();
    }

    // Might have to abandon this in the spirit of getting shit working fast, don't care about the finished tasks for now!
    //void CompleteTask(Task _task)
    //{
    //    TasksCompleted.Add(_task);
    //}

}
