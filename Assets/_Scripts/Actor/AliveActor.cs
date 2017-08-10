using Ultimate;
using UnityEngine;

public class AliveActor : Actor
{
    public GameManager game { private set; get; }
    public InstanceManager instanceManager { private set; get; }
    public Vector3 destination { set; get; }

    private StateController[] ctrls;
    private StateController mainCtrl;

    public override void Init()
    {
        base.Init();
        ctrls = GetComponents<StateController>();
        foreach (StateController ctrl in ctrls)
        {
            ctrl.Init();

            if (ctrl.GetName() == "Main")
            {
                mainCtrl = ctrl;
                continue;
            }
        }

        game = GameManager.instance;
        instanceManager = InstanceManager.instance;

    }

    public override void ManualUpdate()
    {
        base.ManualUpdate();
        if (!mainCtrl)
        {
            Debug.LogWarning("Not Found Ctrl");
            return;
        }
        mainCtrl.ManualUpdate();
    }
}
