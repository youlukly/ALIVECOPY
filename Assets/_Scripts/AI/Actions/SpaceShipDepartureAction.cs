using Ultimate;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/SpaceShip Departure")]
public class SpaceShipDepartureAction : Action
{
    private SpaceShip spaceShip;
    private InstanceManager instanceManager;

    public override void Init(Actor actor)
    {
        spaceShip = actor as SpaceShip;
        instanceManager = InstanceManager.instance;
    }

    public override void ActOnEnter()
    {
        spaceShip.destination = instanceManager.SpaceShipManager.GetLandingPoint();
    }
}
