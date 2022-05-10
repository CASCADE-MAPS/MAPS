using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Task))]
public class TaskEditor : Editor
{
    //public override void OnInspectorGUI()
    //{
    //    //DrawDefaultInspector();
    //    Task task = (Task)target;
    //    if (task.SubTasks == null)
    //    {
    //        task.SubTasks = new SubTask[1];
    //    }
    //    if (task.SubTasks.Length == 0)
    //    {
    //        task.SubTasks = new SubTask[1];
    //    }


    //    // Get all sub tasks in project
    //    List<SubTask> allSubTasks = ReflectiveEnumerator.GetListOfType<SubTask>();
    //    if(allSubTasks.Count == 0)
    //    {
    //        GUILayout.Label("No SubTasks exist, please create a new sub task which inherits the abstract \"SubTask\" class");
    //        return;
    //    }

    //    GUILayout.Label(allSubTasks.Count.ToString());


    //    //for (int i = 0; i < task.SubTasks.Length; i++)
    //    //{
    //    //    task.SubTasks[i] = (SubTask)EditorGUILayout.PropertyField(task.SubTasks[i], "Sub Task " + (i + 1).ToString(), null);
    //    //}
    //}
}
