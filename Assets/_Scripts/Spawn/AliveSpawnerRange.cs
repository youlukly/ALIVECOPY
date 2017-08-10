using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveSpawnerRange : AliveSpawnerBase
{
    [Range(1, 20)] [SerializeField] private float range;

    private AliveSpawnManager manager;

    private void Awake()
    {
        manager = FindObjectOfType<AliveSpawnManager>();
        if (!manager)
        {
            Debug.LogWarning("no SpawnManager detected.");
            return;
        }
    }

    public override void Spawn()
    {
        if (!manager)
        {
            Debug.LogWarning("no SpawnManager detected.");
            return;
        }
        manager.Spawn(new RangeSpawn(spawnableMesh, transform.position , range));
    }

    private void OnDrawGizmos()
    {
        UnityEditor.Handles.color = new Color(1 , 1 , 0.1f , 0.25f);
        UnityEditor.Handles.DrawSolidDisc(transform.position, Vector3.up, range);
    }
}
