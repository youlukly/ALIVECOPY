using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlivePlaySceneCamera : UGLThirdPersonCamera
{
    public void SetAndroidPivot()
    {
        SetPivot(InstanceManager.instance.Android.transform);
    }
    public void SetSpaceShipPivot()
    {
        SetPivot(InstanceManager.instance.SpaceShip.transform);
    }
    public void SetScientistPivot()
    {
        SetPivot(InstanceManager.instance.Scientist.transform);
    }
}
