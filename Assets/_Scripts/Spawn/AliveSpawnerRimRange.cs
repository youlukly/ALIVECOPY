using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveSpawnerRimRange : AliveSpawnerBase
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
        manager.Spawn(new RimRangeSpawn(spawnableMesh, transform.position, range));
    }

    private void OnDrawGizmos()
    {
        UnityEditor.Handles.color = new Color(1.0f, 0.5f, 0.0f, 0.75f);
        UnityEditor.Handles.DrawWireDisc(transform.position,Vector3.up,range);
    }
}
