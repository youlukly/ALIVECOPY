using Ultimate;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/EnemyTargetDirectioning")]
public class EnemyTargetDirectioning : Action
{
    private AliveEnemy enemy;

    public override void Init(Actor actor)
    {
        enemy = actor as AliveEnemy;
    }

    public override void ActOnUpdate()
    {
        enemy.MakeDirection(enemy.target.transform.position);
    }
}
