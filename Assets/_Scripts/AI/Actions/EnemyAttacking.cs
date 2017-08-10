using System.Collections;
using System.Collections.Generic;
using Ultimate;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/EnemyAttacking")]
public class EnemyAttacking : Action
{
    private AliveEnemy enemy;
    private float nowTime;

    public override void Init(Actor actor)
    {
        enemy = actor as AliveEnemy;
    }

    public override void ActOnEnter()
    {
        Debug.Log("Attack");
        enemy.agent.isStopped = true;
    }

    public override void ActOnExit()
    {
        Debug.Log("Attack");
        enemy.agent.isStopped = false;
    }

    public override void ActOnUpdate()
    {
        if (nowTime >= enemy.Data.AttackSpeed)
        {
            float angle = Vector3.Angle(enemy.GetDirectionToTarget(), enemy.transform.forward);
            if (angle > enemy.Data.AttackAngle * 0.5f)
                return;

            nowTime = 0.0f;
            enemy.Attack();
            return;
        }

        nowTime += Ultimate.Time.globalDeltaTime;
    }
}
