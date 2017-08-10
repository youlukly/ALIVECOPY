using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate.AI;
using Ultimate;

[CreateAssetMenu(menuName = "PluggableAI/Actions/AndroidAttacking")]
public class AndroidAttacking : Action
{
    [Range(0, 150)]
    [SerializeField]
    private float joystickExceptionRange;
    private UIActionManager actionManager;
    private AliveAndroid android;
    private InputManager input;

    public override void Init(Actor actor)
    {
        android = actor as AliveAndroid;
        actionManager = FindObjectOfType<UIActionManager>();
        input = UGL.inputManager;
    }

    public override void ActOnUpdate()
    {
        if (!input.GetKey(Tags.RightTouch))
            return;

        float distance = actionManager.GetAttackstickDirection().sqrMagnitude;
        //Debug.Log(Mathf.Sqrt(distance));

        if (distance < joystickExceptionRange * joystickExceptionRange)
            return;

        android.Attack();
    }
}
