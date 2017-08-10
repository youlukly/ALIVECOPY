using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class AndroidManager : MonoBehaviour
{
    [SerializeField] private SubWeaponType subWeapon;

    private GameManager game;

    private void Awake()
    {
        game = GameManager.instance;
    }

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

    public AliveAndroid CreateAndroid()
    {
        AliveAndroid android = UGL.contentsManager.CreateInstance<AliveAndroid>("Androids");
        android.Init();

        return android;
    }
}
