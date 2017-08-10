using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Ultimate;

[CreateAssetMenu(menuName = "PluggableAI/Actions/IdleAction")]
public class AndroidIdleAction : Ultimate.Action
{
    private Actor actor;

    public override void ActOnEnter()
    {
        Debug.Log("IdleAction");
        if (actor.animator.GetBool(AnimationID.Attack))
            actor.animator.SetBool(AnimationID.Attack, false);
        if (actor.animator.GetBool(AnimationID.Walk))
            actor.animator.SetBool(AnimationID.Walk, false);
        if (actor.animator.GetBool(AnimationID.Run))
            actor.animator.SetBool(AnimationID.Run, false);
    }

    public override void ActOnUpdate()
    {
        if (actor.speed == 0.0f)
            return;

        if (actor.speed <= 0.0f)
        {
            actor.speed = 0.0f;
            return;
        }

        actor.speed -= Ultimate.Time.globalDeltaTime * actor.accel;
        //Debug.Log(actor.speed);
    }

    public override void Init(Actor actor)
    {
        this.actor = actor;
    }
}
