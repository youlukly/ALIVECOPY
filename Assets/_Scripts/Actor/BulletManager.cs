using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class BulletManager : AliveBehavior
{
    [SerializeField] private int poolingCount = 50;
    public void Init()
    {
        contents.LoadResource(Tags.Bullets);
        List<string> bulletPrefabNames = new List<string>();
        bulletPrefabNames = contents.GetResourceName(Tags.Bullets);
        foreach (string prefabName in bulletPrefabNames)
        {
            Bullet bullet = contents.GetResource<Bullet>(prefabName);
            contents.CreateInstancePool(new InstancePool(bullet.Data.Type.ToString(), bullet.gameObject, poolingCount));
        }
    }

    public Bullet CreateBullet(BulletType type, Vector3 pos, Vector3 direction)
    {
        contents.CreateInstance<Bullet>(type.ToString()).Init(pos, direction);
        return null;
    }
}
