using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MainWeaponBase : ScriptableObject
{
    [SerializeField] private MainWeaponType type;
    [SerializeField] private BulletType bulletType;
    [SerializeField] private ActorType fxType;
    [SerializeField] private string bulletPrefabName;
    [SerializeField] private float ammo;
    [SerializeField] private float recoveryAmmo;
    [SerializeField] private float recoveryAccelMax;
    [SerializeField] private string soundRscName;
    [SerializeField] private float distance;
    [SerializeField] private float angle;
    [SerializeField] private int damage;
    [SerializeField] private float fireSpeed;
    [SerializeField] private float damageMinRate;
    [SerializeField] private float damageMaxRate;
    [SerializeField] private float criticalChance;
    [SerializeField] private float criticalDamageRate;
    [SerializeField] private float hitTime;

    protected BulletManager bulletManager;
    protected AliveAndroid android;

    public virtual void Init(AliveAndroid android)
    {
        bulletManager = InstanceManager.instance.BulletManager;
        this.android = android;
    }

    public abstract void ShootingMethod();

    public abstract void ShootFX();

    public MainWeaponType Type
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

    public BulletType BulletType
    {
        get
        {
            return BulletType;
        }

        set
        {
            bulletType = value;
        }
    }

    public ActorType FxType
     {
        get
        {
            return fxType;
        }

        set
        {
            FxType = value;
        }
    }

    public float Ammo
    {
        get
        {
            return ammo;
        }

        set
        {
            ammo = value;
        }
    }

    public float RecoveryAmmo
    {
        get
        {
            return recoveryAmmo;
        }

        set
        {
            recoveryAmmo = value;
        }
    }

    public float RecoveryAccelMax
    {
        get
        {
            return recoveryAccelMax;
        }

        set
        {
            recoveryAccelMax = value;
        }
    }

    public string SoundRscName
    {
        get
        {
            return soundRscName;
        }

        set
        {
            soundRscName = value;
        }
    }

    public float Distance
    {
        get
        {
            return distance;
        }

        set
        {
            distance = value;
        }
    }

    public float Angle
    {
        get
        {
            return angle;
        }

        set
        {
            angle = value;
        }
    }

    public int Damage
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

    public float FireSpeed
    {
        get
        {
            return fireSpeed;
        }

        set
        {
            fireSpeed = value;
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
            return damageMaxRate;
        }

        set
        {
            damageMaxRate = value;
        }
    }

    public float CriticalChance
    {
        get
        {
            return criticalChance;
        }

        set
        {
            criticalChance = value;
        }
    }

    public float CriticalDamageRate
    {
        get
        {
            return criticalDamageRate;
        }

        set
        {
            CriticalDamageRate = value;
        }
    }

    public float HitTime
    {
        get
        {
            return hitTime;
        }

        set
        {
            hitTime = value;
        }
    }
}
