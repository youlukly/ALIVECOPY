using Ultimate;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Actor Move")]
public class ActorMove : Action
{
    private Actor actor;

    public override void Init(Actor actor)
    {
        this.actor = actor;
    }

    public override void ActOnUpdate()
    {
        if (actor.speed < actor.maxSpeed)
            actor.speed += Ultimate.Time.globalDeltaTime * actor.accel;

        actor.agent.Move(actor.direction * Ultimate.Time.globalDeltaTime * actor.speed);
    }
}
