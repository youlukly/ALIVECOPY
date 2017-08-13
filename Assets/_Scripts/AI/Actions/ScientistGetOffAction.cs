using Ultimate;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Scientis GetOff")]
public class ScientistGetOffAction : Action
{
    private Scientist scientist;
    private InstanceManager instanceManager;

    public override void Init(Actor actor)
    {
        scientist = actor as Scientist;
        instanceManager = InstanceManager.instance;
    }

    public override void ActOnEnter()
    {
        scientist.destination = instanceManager.SpaceShipManager.GetgetOffPoint();
    }

    public override void ActOnExit()
    {
        GameManager.instance.playScene.GoToPlay();
    }
}
