using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehaviorBase : ScriptableObject
{
    private AliveEnemy enemy;
    public void Init(AliveEnemy enemy)
    {
        this.enemy = enemy;
    }

    public abstract void Excute();

    public abstract void ExcuteFX();
}
