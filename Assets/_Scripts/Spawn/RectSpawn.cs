using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectSpawn : SpawnBase
{
    private Vector3 center;
    private float row;
    private float col;

    public RectSpawn(MeshFilter spawnableMesh, Vector3 center, float row, float col) : base(spawnableMesh)
    {
        this.center = center;
        this.row = row;
        this.col = col;
    }

    public override void Spawn()
    {
        Vector3 tempPoint = SpawnPointSetting(center, row, col);
    }


    private Vector3 SpawnPointSetting(Vector3 spawnPoint, float rangeX, float rangeZ)
    {
        Vector3 randomVector = new Vector3(
            spawnPoint.x +
            Random.Range(-rangeX/2, rangeX/2),
            0,
            spawnPoint.z +
            Random.Range(-rangeZ/2, rangeZ/2)
            );
        return randomVector;
    }
}
