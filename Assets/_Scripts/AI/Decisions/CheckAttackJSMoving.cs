using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/CheckAttack")]
public class CheckAttackJSMoving : Decision
{
    private AliveAndroid android;
    private UIActionManager actionManager;
    private InputManager input;

    public override void Init(Actor actor)
    {
        actionManager = FindObjectOfType<UIActionManager>();
        android = actor as AliveAndroid;
        input = UGL.inputManager;
    }

    public override bool Decide()
    {
        if (input.GetKey("rightTouch") && actionManager.GetAttackstickDirection() != Vector2.zero)
            android.Alert();

        return android.alert;
    }
}
