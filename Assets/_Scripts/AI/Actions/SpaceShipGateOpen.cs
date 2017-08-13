using Ultimate;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/SpaceShip GateOpen")]
public class SpaceShipGateOpen : Action
{
    private SpaceShip spaceShip;

    public override void Init(Actor actor)
    {
        spaceShip = actor as SpaceShip;
    }

    public override void ActOnEnter()
    {
        spaceShip.GateOpen();
    }
}
