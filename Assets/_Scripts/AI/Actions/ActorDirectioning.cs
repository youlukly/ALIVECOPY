using Ultimate;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Actor Directioning")]
public class ActorDirectioning : Action
{
    private AliveActor actor;
    //private Vector3 prev;


    public override void Init(Actor actor)
    {
        this.actor = actor as AliveActor;
    }

    public override void ActOnEnter()
    {
        //prev = actor.transform.position;
    }

    public override void ActOnUpdate()
    {
        actor.direction = (actor.destination - actor.transform.position).normalized;
        //if(actor.transform.position != prev)
        //{
        //    Vector3 dir = actor.transform.position - prev;
        //    actor.direction = dir.normalized;
        //    prev = actor.transform.position;
        //}
    }
}
