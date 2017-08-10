using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public abstract class SpawnBase
{
    protected MeshFilter spawnableMesh;
    protected ContentsManager contentsManager;

    public SpawnBase(MeshFilter spawnableMesh)
    {
        contentsManager = UGL.contentsManager;
        this.spawnableMesh = spawnableMesh;
    }

    public abstract void Spawn();
}
