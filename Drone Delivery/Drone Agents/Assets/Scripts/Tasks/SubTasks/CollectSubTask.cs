using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSubTask : SubTask
{
    GameObject asset;

    public CollectSubTask(GameObject _asset)
    {
        asset = _asset;
    }

    public override void DoSubTask(Controller controller)
    {
        controller.CollectAsset(asset);
    }
}
