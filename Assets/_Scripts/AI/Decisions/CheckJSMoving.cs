using UnityEngine;
using Ultimate;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/CheckMoving")]
public class CheckJSMoving : Decision
{
    private UIActionManager actionManager;

    public override void Init(Actor actor)
    {
        actionManager = FindObjectOfType<UIActionManager>();
    }

    public override bool Decide()
    {
        //Debug.Log(actionManager.GetJoystickDirection());
        return actionManager.GetJoystickDirection() != Vector2.zero;
    }
}
