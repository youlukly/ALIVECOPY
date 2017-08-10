using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AliveCoreBase
{
    [HideInInspector] public int corePrice;

    public abstract void ManualUpdate();
}
