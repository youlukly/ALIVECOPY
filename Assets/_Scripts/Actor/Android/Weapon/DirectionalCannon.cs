using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

[CreateAssetMenu(menuName ="ALIVE/Weapon/Main/Directional Cannon")]
public class DirectionalCannon : MainWeaponBase
{
    private ContentsManager contents;
    private AliveAndroid android;

    public void Init(AliveAndroid android)
    {
        contents = UGL.contentsManager;
        this.android = android;
    }

    public void ShootFX()
    {
    }

    public void ShootingMethod()
    {
        contents.CreateInstance<Bullet>(Tags.Bullets).Init(Damage, android.transform.position + android.topDir, android.topDir);
    }
}
