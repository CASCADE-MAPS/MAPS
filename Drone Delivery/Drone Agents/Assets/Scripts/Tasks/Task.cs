using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//[CreateAssetMenu(fileName = "Task", menuName = "Task Objects/New Task", order = 1)]
public class Task
{
    public UnityEvent OnTaskComplete_Event = new UnityEvent();

    // Array of sub tasks which make up the entire task
    [SerializeReference]
    public SubTask[] SubTasks = new SubTask[0];

    // Index of the current sub task
    private int current;

    // Add a new sub task and listen to the complete event so we can move on when the sub task is finished
    public void AddSubTask(SubTask _newSubTask)
    {
        SubTask[] oldST = SubTasks;
        SubTasks = new SubTask[oldST.Length + 1];
        for (int i = 0; i < oldST.Length; i++)
        {
            SubTasks[i] = oldST[i];
        }

        SubTasks[oldST.Length] = _newSubTask;
        _newSubTask.OnSubTaskComplete_Event.AddListener(MoveToNextSubTask);
    }

    public SubTask CurrentSubTask()
    {
        return SubTasks[current];
    }

    void MoveToNextSubTask()
    {
        // Increment the sub task index / counter
        current++;

        // Check if that was the last sub task to finish
        if(current >= SubTasks.Length)
        {
            OnTaskComplete_Event.Invoke();
        }
    }
}
