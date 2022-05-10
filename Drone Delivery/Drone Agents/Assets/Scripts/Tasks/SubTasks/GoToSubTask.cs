using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSubTask : SubTask
{
    public Vector3 target;

    public GoToSubTask(Vector3 _target)
    {
        target = _target;
    }

    public override void DoSubTask(Controller controller)
    {
        controller.MoveToTarget(target);
    }

}
