using System;
using Ultimate;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Actor Remaining")]
public class CheckActorHasRemaining : Decision
{
    private AliveActor actor;

    public override bool Decide()
    {
        return (actor.destination - actor.transform.position).sqrMagnitude >= 0.35f;
    }

    public override void Init(Actor actor)
    {
        this.actor = actor as AliveActor;
    }
}
