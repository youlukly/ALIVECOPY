using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AliveSpaceShipCoreBase
{
    [HideInInspector] public int corePrice;

    public abstract void ManualUpdate();
}
