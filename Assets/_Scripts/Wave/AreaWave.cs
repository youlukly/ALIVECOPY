using UnityEngine;
using System;

[CreateAssetMenu(menuName = "ALIVE/Data/AreaWave")]
public class AreaWave : WaveBase
{
    [SerializeField] private AliveSpawnerBase spawner;
    private float waveUpdateTime = 0.0f;
    private int waveUpdateCount = 0;

    public override void Init()
    {
        spawnManager = FindObjectOfType<AliveSpawnManager>();
    }

    public override void ManualUpdate()
    {
        if (waveUpdateCount == WaveCount)
            isActive = false;

        waveUpdateTime += Time.deltaTime;
        if(waveUpdateTime <=waveGapTime)
        {
            return;
        }
        waveUpdateTime = 0.0f;
        waveUpdateCount++;
        for (int i = 0; i < unitsPerWave; i++)
            WaveStart();
    }

    public override void WaveStart()
    {
        spawnManager.Spawn(spawner);
    }

    public override bool CheckActiveState()
    {
        return isActive;
    }
}
