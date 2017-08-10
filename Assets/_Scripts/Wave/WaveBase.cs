using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WaveBase : ScriptableObject
{
    protected AliveSpawnManager spawnManager;

    [SerializeField] protected float waveGapTime;
    [SerializeField] protected int WaveCount;
    [SerializeField] protected int unitsPerWave;
    protected bool isActive = true;

    public abstract void Init();
    
    public abstract void ManualUpdate();

    public abstract void WaveStart();

    public abstract bool CheckActiveState();
}
