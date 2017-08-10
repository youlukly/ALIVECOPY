using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class RangeSpawn : SpawnBase
{
    private Vector3 center;
    private float range;

    public RangeSpawn(MeshFilter spawnableMesh, Vector3 center, float range) : base(spawnableMesh)
    {
        this.center = center;
        this.range = range;
    }
    public override void Spawn()
    {
        Vector3 tempPoint = SpawnPointSetting(center, range);
    }

    private Vector3 SpawnPointSetting(Vector3 spawnPoint, float range)
    {
        Vector3 tempPos = spawnPoint + Random.insideUnitSphere * range;
        tempPos.y = 0.0f; 
        return tempPos;
    }
}
