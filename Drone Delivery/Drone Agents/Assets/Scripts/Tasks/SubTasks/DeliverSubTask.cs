using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverSubTask : SubTask
{
    GameObject asset;

    public DeliverSubTask(GameObject _asset)
    {
        asset = _asset;
    }

    public override void DoSubTask(Controller controller)
    {
        controller.DepositAsset(asset);
    }
}
