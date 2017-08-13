using System.Collections;
using System.Collections.Generic;
using Ultimate;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/EnemyChasing")]
public class EnemyChasing : Action
{
    private AliveEnemy enemy;

    public override void Init(Actor actor)
    {
        enemy = actor as AliveEnemy;
    }

    public override void ActOnEnter()
    {
        Debug.Log("Enter");
    }

    public override void ActOnUpdate()
    {
        enemy.agent.SetDestination(enemy.target.transform.position);
    }
}
