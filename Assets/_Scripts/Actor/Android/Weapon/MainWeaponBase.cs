using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWeaponBase : ScriptableObject
{
    private MainWeaponType type;
    private BulletType bulletType;
    private ActorType fxType;
    private string bulletPrefabName;
    private float ammo;
    private float recoveryAmmo;
    private float recoveryAccelMax;
    private string soundRscName;
    private float distance;
    private float angle;
    private int damage;
    private float fireSpeed;
    private float damageMinRate;
    private float damageMaxRate;
    private float criticalChance;
    private float criticalDamageRate;
    private float hitTime;
    
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

    public string BulletPrefabName
    {
        get
        {
            return bulletPrefabName;
        }

        set
        {
            bulletPrefabName = value;
        }
    }



    public void Init(AliveAndroid android)
    {

    }

    public void ShootingMethod()
    {

    }

    public void ShootFX()
    {

    }
}
