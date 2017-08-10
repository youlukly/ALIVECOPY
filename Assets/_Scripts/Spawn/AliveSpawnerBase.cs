using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AliveSpawnerBase : MonoBehaviour
{
    [SerializeField] protected MeshFilter spawnableMesh;

    public abstract void Spawn();
}
