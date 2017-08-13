using Ultimate;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/SpaceShip Landing")]
public class SpaceShipLandingAction : Action
{
    private SpaceShip spaceShip;

    public override void Init(Actor actor)
    {
        spaceShip = actor as SpaceShip;
    }

    public override void ActOnEnter()
    {
        spaceShip.Land();
    }
}
