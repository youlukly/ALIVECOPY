using UnityEngine;
using Ultimate;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/SpaceShip Landed")]
public class CheckSpaceShipLanded : Decision
{
    private SpaceShip spaceShip;

    public override void Init(Actor actor)
    {
        spaceShip = actor as SpaceShip;
    }

    public override bool Decide()
    {
        //Debug.Log(actionManager.GetJoystickDirection());
        return spaceShip.landed;
    }
}
