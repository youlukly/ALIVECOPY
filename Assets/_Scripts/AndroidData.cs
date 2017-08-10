using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="AndroidData")]
public class AndroidData : ScriptableObject
{
    private AndroidType type;
    private ActorType actorType;
    private string description;
    private int index;

    public int hpIncrease;
    public int defenceIncrease;

    private float attackingRotateSpeed;
    private float rotateSpeed;
    private float maxSpeed;
    private float accel;
    private int damageIncrease;
    private float targettingRange;
    private float meleeRange;
    private float alertTime;
    private float level;
    private float defence;
    private float damage;
    private string resourcePath;
    private int hp;

    public float TarggetingRange
    {
        get
        {
            return targettingRange;
        }
        set
        {
            targettingRange = value;
        }
    }
    public AndroidType Type
    {
        get
        {
            return type;
        }
        set
        {
            type = value;
        }
    }
    public string Description
    {
        get
        {
            return description;
        }
        set
        {
            description = value;
        }
    }
    public ActorType ActorType
    {
        get
        {
            return actorType;
        }
        set
        {
            actorType = value;
        }
    }
    public int Index
    {
        get
        {
            return index;
        }
        set
        {
            index = value;
        }
    }
    public int HPIncrease
    {
        get
        {
            return hpIncrease;
        }
        set
        {
            hpIncrease = value;
        }
    }
    public int DefenceIncrease
    {
        get
        {
            return defenceIncrease;
        }
        set
        {
            defenceIncrease = value;
        }
    }
    public float AttackingRotateSpeed
    {
        get
        {
            return attackingRotateSpeed;
        }
        set
        {
            attackingRotateSpeed = value;
        }
    }
    public float RotateSpeed
    {
        get
        {
            return rotateSpeed;
        }
        set
        {
            rotateSpeed = value;
        }
    }
    public float MaxSpeed
    {
        get
        {
            return maxSpeed;
        }
        set
        {
            maxSpeed = value;
        }
    }
    public float Accel
    {
        get
        {
            return accel;
        }
        set
        {
            accel = value;
        }
    }
    public int DamageIncrease
    {
        get
        {
            return damageIncrease;
        }
        set
        {
            damageIncrease = value;
        }
    }

    public float MeleeRange
    {
        get
        {
            return meleeRange;
        }
        set
        {
            meleeRange = value;
        }
    }

    public float AlertTime
    {
        get
        {
            return alertTime;
        }
        set
        {
            alertTime = value;
        }
    }

    public float Level
    {
        get
        {
            return level;
        }
        set
        {
            level = value;
        }
    }

    public float Defence
    {
        get
        {
            return defence;
        }
        set
        {
            defence = value;
        }
    }

    public float Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }

    public string ResourcePath
    {
        get
        {
            return resourcePath;
        }
        set
        {
            resourcePath = value;
        }
    }

    public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }
}
