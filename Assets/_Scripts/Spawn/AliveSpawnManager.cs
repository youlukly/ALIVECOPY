using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveSpawnManager : MonoBehaviour
{
    public void Spawn(SpawnBase spawnMethod)
    {
        spawnMethod.Spawn();
    }

    public void Spawn(AliveSpawnerBase spawner)
    {
        spawner.Spawn();
    }
}
