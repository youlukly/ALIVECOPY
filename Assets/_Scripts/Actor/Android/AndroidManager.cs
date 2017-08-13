using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class AndroidManager : AliveBehavior
{
    [SerializeField] private SubWeaponType subWeapon;

    public AliveAndroid android { private set; get; }

    public void Init()
    {
        UGL.contentsManager.LoadResource("Androids/");
        UGL.contentsManager.CreateInstancePool(
            new InstancePool("Androids"
            , UGL.contentsManager.GetResource(game.account.GetSelectedAndroid())
            ,1));
    }

    public SubWeaponType GetSubWeaponType()
    {
        return subWeapon;
    }

    public AndroidSubWeapon CreateSubWeapon(SubWeaponType type)
    {
        return null;
    }

    public void CreateAndroid()
    {
        android = UGL.contentsManager.CreateInstance<AliveAndroid>("Androids");
        android.transform.position = instanceManager.SpaceShipManager.GetAndroidCreatePoint();
    }
}
