using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleetManager : BaseManager
{
    /* Fleet manager is in charge of delegation for a subset of drones in the scene
     * The manager needs to keep track of jobs which are waiting, in progress, and completed
     * It also needs to track the agents which are busy and those which are available
     * I think queues are a good start, priority can be added in the future if necessary
     */

    // How many drones are managed by this object
    public int fleetSize;

    // Used for creating the drones in start
    public GameObject dronePrefab;

    // Where to send the drones when they are done
    public Transform[] hangars;

    Queue<Task> TasksWaiting = new Queue<Task>();
    //List<Task> TasksInProgress = new List<Task>();
    List<Task> TasksCompleted = new List<Task>();

    Queue<Agent> AvailableAgents = new Queue<Agent>();


    // Start is called before the first frame update
    void Start()
    {
        // The task manager is a global manager and would pick up the drones managed by this fleet
        TaskManager tm = FindObjectOfType<TaskManager>();
        if (tm)
        {
            Debug.LogError("Task Manager found in scene on " + tm.gameObject.name + ". This will conflict with the fleet manager on " + gameObject.name);
        }

        // Fleet manager creates its own agents to keep things simple!
        if (hangars == null || hangars.Length == 0)
        {
            for (int i = 0; i < fleetSize; i++)
            {
                GameObject drone = Instantiate(dronePrefab, transform.position, Quaternion.identity, transform);
                drone.name = gameObject.name + " drone " + i.ToString();
                Agent agent = drone.GetComponent<Agent>();
                if (!agent)
                {
                    Debug.LogError("Drone prefab " + dronePrefab.name + " has no agent script attached. On manager object: " + gameObject.name);
                }
                agent.GiveManager(this);
                AvailableAgents.Enqueue(agent);
            }
        }
        else
        {
            for (int i = 0; i < fleetSize; i++)
            {
                Vector3 hangarPos = hangars[Random.Range(0, hangars.Length)].position;
                GameObject drone = Instantiate(dronePrefab, hangarPos, Quaternion.identity, transform);
                drone.name = gameObject.name + " drone " + i.ToString();
                Agent agent = drone.GetComponent<Agent>();
                
                // Make sure there is an agent component
                if (!agent)
                {
                    Debug.LogError("Drone prefab " + dronePrefab.name + " has no agent script attached. On manager object: " + gameObject.name);
                }
                agent.GiveManager(this);

                // This position can be changed at any time, so we could also keep track of how many drones are
                // assigned to each hangar? idk
                agent.hangarPosition = hangarPos;
                AvailableAgents.Enqueue(agent);
            }
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
        if (AvailableAgents.Count >= 1)
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

    public void MakeDeliveryRequest(Transform destination)
    {
        // First we want to select the delivery source from which we send the package
        // Doing this at random for now
        Transform source = hangars[Random.Range(0, hangars.Length)];

        // Create package and move it to source position, need offsets etc but should do for now
        GameObject package = GameObject.CreatePrimitive(PrimitiveType.Cube);
        package.transform.localScale = new Vector3(0.25f, 0.2f, 0.25f);
        package.transform.position = source.position;
        package.transform.SetParent(transform);

        // Ideally I want this all predefined in a scriptable object, but there are so many
        // parameters required for each subtask that writing the custom inspector is going to
        // be a big time sink. So for now it's hard coded, yay!
        Task deliveryTask = new Task();

        // ST 0 - Go to package
        deliveryTask.AddSubTask(new GoToSubTask(source.position));

        // ST 1 - Collect package
        deliveryTask.AddSubTask(new CollectSubTask(package));

        // ST 2 - Go to destination
        deliveryTask.AddSubTask(new GoToSubTask(destination.position));

        // ST 3 - Deliver package
        deliveryTask.AddSubTask(new DeliverSubTask(package));

        AddNewTask(deliveryTask);
    }
}
