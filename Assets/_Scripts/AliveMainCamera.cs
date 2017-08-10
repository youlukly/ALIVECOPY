using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveMainCamera : UGLThirdPersonCamera
{

    public void SetPivot()
    {
        SetPivot(UniqueActors.instance.android.transform);
    }

}
