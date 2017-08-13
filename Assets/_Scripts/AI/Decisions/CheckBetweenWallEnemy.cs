using UnityEngine;
using Ultimate;
using System;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Enemy/BetweenWall")]
public class CheckBetweenWallEnemy : Decision
{
    private AliveEnemy enemy;

    public override bool Decide()
    {
        Vector3 fixPos = new Vector3(enemy.transform.position.x,0.5f,enemy.transform.position.z);
        Ray ray = new Ray(fixPos,enemy.GetDirectionToTarget());
        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(ray.origin,ray.direction * 100,Color.red , 1);

        if (Physics.Raycast(ray, out hit, float.MaxValue))
        {
            if (hit.collider.CompareTag(Tags.Wall))
                return true;
        }

        return false;
    }

    public override void Init(Actor actor)
    {
        enemy = actor as AliveEnemy;
    }
}
