using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData: ScriptableObject
{
    private EnemyType type;
    private EnemyGrade grade;
    private EnemySeries seriesType;
    private ActorType actorType;
    private UniqueActorType firstTargetType;
    private int exp;
    private int gold;
    private int index;
    private float scale;
    private float speed;
    private float createRate;
    private string description;
    private string resourcePath;
    private float hp;
    private float defence;
    private float damage;
    private float damageMinRate;
    private float damageMaxRate;
    private float sight;
    private float attackRange;
    private float attackSpeed;
    private float attackAngle;
    private float rotateSpeed;
    private float accel;

    public EnemyType Type
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

    public EnemyGrade EnemyGrade
    {
        get
        {
            return grade;
        }

        set
        {
            grade = value;
        }
    }

    public EnemySeries EnemySeries
    {
        get
        {
            return seriesType; 
        }

        set
        {
            seriesType = value;
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

    public int Exp
    {
        get
        {
            return exp;
        }

        set
        {
            exp = value;
        }
    }

    public int Gold
    {
        get
        {
            return gold;
        }

        set
        {
            gold = value;
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

    public float Scale
    {
        get
        {
            return scale;
        }

        set
        {
            scale = value;
        }
    }

    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public float CreateRate
    {
        get
        {
            return createRate;
        }

        set
        {
            createRate = value;
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

    public float Hp
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

    public float DamageMinRate
    {
        get
        {
            return damageMinRate;
        }

        set
        {
            damageMinRate = value;
        }
    }

    public float DamageMaxRate
    {
        get
        {
            return DamageMaxRate;
        }

        set
        {
            DamageMaxRate = value;
        }
    }

    public float Sight
    {
        get
        {
            return sight;
        }

        set
        {
            sight = value;
        }
    }

    public float AttackRange
    {
        get
        {
            return attackRange;
        }

        set
        {
            attackRange = value;
        }
    }

    public float AttackSpeed
    {
        get
        {
            return attackSpeed;
        }

        set
        {
            attackSpeed = value;
        }
    }

    public float AttackAngle
    {
        get
        {
            return attackAngle;
        }

        set
        {
            attackAngle = value;
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

    public UniqueActorType FirstTargetType
    {
        get
        {
            return firstTargetType;
        }

        set
        {
            firstTargetType = value;
        }
    }
}
