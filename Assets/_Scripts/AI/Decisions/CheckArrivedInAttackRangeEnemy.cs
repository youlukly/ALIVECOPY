using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;
using System;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/CheckArrivedInAttackRangeEnemy")]
public class CheckArrivedInAttackRangeEnemy : Decision
{
    private AliveEnemy enemy;

    public override bool Decide()
    {
        float distance = (enemy.transform.position - enemy.target.transform.position).sqrMagnitude;
        return distance <= enemy.Data.AttackRange * enemy.Data.AttackRange;
    }

    public override void Init(Actor actor)
    {
        actor = actor as AliveEnemy;
    }
}
