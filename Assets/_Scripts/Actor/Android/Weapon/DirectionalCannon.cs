using UnityEngine;
using Ultimate;

[CreateAssetMenu(menuName ="ALIVE/Weapon/Main/Directional Cannon")]
public class DirectionalCannon : MainWeaponBase
{
    public override void ShootFX()
    {
    }

    public override void ShootingMethod()
    {
        Debug.Log("Shoot");
        bulletManager.CreateBullet(BulletType, android.transform.position + android.topDir, android.topDir);
    }
}
