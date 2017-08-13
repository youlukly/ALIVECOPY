using UnityEngine;
using Ultimate;

[CreateAssetMenu(menuName = "PluggableAI/Actions/JoystickOriginDirectioning")]
public class JoystickOriginDirectioningAction : Ultimate.Action
{
    private AliveAndroid android;
    private UIActionManager actionManager;

    public override void Init(Actor actor)
    {
        this.android = actor as AliveAndroid;
        actionManager = FindObjectOfType<UIActionManager>();
    }

    public override void ActOnUpdate()
    {
        Vector3 jsDir = actionManager.GetJoystickDirection();

        Vector3 convert = Vector3.Normalize(new Vector3(jsDir.x,0,jsDir.y));
        android.direction = Vector3.Lerp(android.direction, convert.normalized, Ultimate.Time.globalDeltaTime);

    }
}
