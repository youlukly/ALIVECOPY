using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class AndroidWeapon : AliveBehavior
{
    [SerializeField] private SkinnedMeshRenderer weaponRenderer;

    [SerializeField] private MainWeaponBase mainWeapon;

    public AndroidSubWeapon subWeapon { private get; set; }
    public bool overHitting { private get; set; }
    public float nowAmmo { private get; set; }
    protected float nowRecoveryAccel;

    private AliveAndroid android;
    private bool coolDown = false;
    private float coolDownNowTime = 0.0f;

    public void Init()
    {
        if (!mainWeapon)
        {
            Debug.LogError("Not Serialized Main Weapon");
            return;
        }

        android = GetComponent<AliveAndroid>();
        mainWeapon.Init(android);

        nowAmmo = mainWeapon.Ammo;

        SubWeaponType subWeaponType = instanceManager.AndroidManager.GetSubWeaponType();

        if (game.account != null)
            subWeaponType = game.account.GetSelectedSubWeapon();

        if (subWeaponType == SubWeaponType.SubWeaponType_None)
            return;

        instanceManager.AndroidManager.CreateSubWeapon(subWeaponType).Init();

    }

    public Material GetMaterial()
    {
        return weaponRenderer.material;
    }

    public void Shoot()
    {
        if (coolDown)
            return;

        coolDown = true;

        if (overHitting)
            return;

        nowRecoveryAccel = 0.0f;

        if (nowAmmo <= 0)
        {
            OverHit();
            return;
        }

        mainWeapon.ShootFX();

        mainWeapon.ShootingMethod();

        nowAmmo--;

        //무기를 착용하지 않은 상태 예외 처리
        if (subWeapon == null)
            return;

        subWeapon.Shoot();
    }

    public void OverHit()
    {
        overHitting = true;
    }

    public void ManualUpdate()
    {
        if (mainWeapon = null)
            return;

        CoolDown();

        if (nowAmmo < mainWeapon.Ammo)
            nowAmmo += Ultimate.Time.globalDeltaTime * mainWeapon.RecoveryAmmo * nowRecoveryAccel;
        else if (overHitting)
            overHitting = false;

        if (nowRecoveryAccel < mainWeapon.RecoveryAccelMax)
            nowRecoveryAccel += Ultimate.Time.globalDeltaTime;

        if (subWeapon == null)
            return;

        subWeapon.ManualUpdate();
    }

    private void CoolDown()
    {
        if (!coolDown)
            return;

        if (coolDownNowTime < mainWeapon.FireSpeed)
        {
            coolDownNowTime += Ultimate.Time.globalDeltaTime;
            return;
        }

        coolDownNowTime = 0.0f;
        coolDown = false;
    }
}
