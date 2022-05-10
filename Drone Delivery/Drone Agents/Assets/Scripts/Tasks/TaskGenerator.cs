using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskGenerator : MonoBehaviour
{
    Transform[] sources;
    Transform[] destinations;

    public TaskManager manager;

    public float deliveryPeriod = 5f;

    System.Random random = new System.Random(2);

    float counter = 0f;

    private void Start()
    {
        sources = GetTaggedTransforms("Source");
        destinations = GetTaggedTransforms("Destination");
    }

    Transform[] GetTaggedTransforms(string tag)
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag(tag);
        Transform[] trs = new Transform[gos.Length];
        for (int i = 0; i < gos.Length; i++)
        {
            trs[i] = gos[i].transform;
        }
        return trs;
    }

    private void FixedUpdate()
    {
        counter = Time.fixedTime;
        if(counter >= deliveryPeriod)
        {
            CreateDeliveryTask();
            counter -= deliveryPeriod;
        }
    }

    void CreateDeliveryTask()
    {
        Transform source = RandomItem(sources);
        Transform destination = RandomItem(destinations);

        // Create package and move it to source position, need offsets etc but should do for now
        //GameObject package = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //package.transform.localScale = new Vector3(0.25f, 0.2f, 0.25f);
        //package.transform.position = source.position;
        //Destroy(package.GetComponent<BoxCollider>());

        GameObject package = new GameObject("Package");
        package.transform.position = source.position;

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

        manager.AddNewTask(deliveryTask);
    }

    Transform RandomItem(Transform[] array)
    {
        return array[random.Next(0, array.Length)];
    }
}
