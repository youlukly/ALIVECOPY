using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class AliveAndroid : Actor
{
    private AndroidData data;
    private Transform top;
    private State initState;

    public Vector3 topDir { private set; get; }
    public StateController contrl { private set; get; }
    public GameObject target;
    public bool alert { private set; get; }

    private UIActionManager actionManager;
    private GameManager game;
    private AndroidWeapon weapon;

    private float alertNowTime = 0.0f;

    private void Awake()
    {
        Init();
    }

    public override void Init()
    {

    }

    public AndroidData GetData()
    {
        return data;
    }

    public Transform GetTopTransform()
    {
        return top;
    }

    public void TopDirectioning(Vector3 dir, float rotSpeed)
    {
        this.transform.forward = Vector3.Lerp(transform.position, dir, rotSpeed);
    }

    public bool IsInRange(Vector3 target,float range)
    {
        return false;
    }

    public void Alert()
    {
        alert = true;
        alertNowTime = 0.0f;
    }

    public void MeleeAttack()
    {
        Debug.Log("MeleeAttack!");
    }

    public void Attack()
    {
        Debug.Log("Attack!");
    }

    public GameObject Targetting(float range,float angle)
    {
        Vector3 jsDir = Vector3.Normalize(new Vector3(actionManager.GetAttackstickDirection().x,0.0f,actionManager.GetAttackstickDirection().y));
        float tmp = float.MaxValue;

        GameObject newTarget = null;

        foreach (InstancePool.Item item in UGL.contentsManager.GetInstancePool("Enemies").enableItems)
        {
            if (!item.uglObject.activeSelf)
                continue;

            Vector3 dirToEnemy = item.uglObject.transform.position - transform.position;
            float distance = dirToEnemy.sqrMagnitude;
            if (distance > range * range)
                continue;

            float btwAngle = Vector3.Angle(jsDir, dirToEnemy);

            if (btwAngle > tmp)
                continue;

            if (btwAngle > angle * 0.5f)
                continue;

            newTarget = item.uglObject;
            tmp = btwAngle;
        }

        return newTarget;
    }

    public override void ManualUpdate()
    {
        base.ManualUpdate();
        contrl.ManualUpdate();
        weapon.ManualUpdate();
        target = Targetting(10.0f, 60.0f);
    }

    public bool IsAlert()
    {
        if (!alert)
            return false;

        alertNowTime += Ultimate.Time.globalDeltaTime;

        return alertNowTime < data.AlertTime;
    }
}
