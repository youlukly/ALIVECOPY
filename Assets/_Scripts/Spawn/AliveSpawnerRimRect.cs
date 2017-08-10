using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveSpawnerRimRect : AliveSpawnerBase
{

    [Range(1, 20)] [SerializeField] private float row;
    [Range(1, 20)] [SerializeField] private float col;

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
        manager.Spawn(new RimRectSpawn(spawnableMesh, transform.position, row, col));
    }

    private void OnDrawGizmos()
    {
        Color faceColor = new Color(1.0f, 0, 0.0f, 0.75f);

        Vector3 leftTop = transform.position - new Vector3(row * 0.5f, 0.0f, -col * 0.5f);
        Vector3 rightTop = transform.position + new Vector3(row * 0.5f, 0.0f, col * 0.5f);
        Vector3 rightBottom = transform.position + new Vector3(row * 0.5f, 0.0f, -col * 0.5f);
        Vector3 leftBottom = transform.position - new Vector3(row * 0.5f, 0.0f, col * 0.5f);

        Vector3[] verts = { leftTop, rightTop, rightBottom, leftBottom };

        UnityEditor.Handles.DrawSolidRectangleWithOutline(verts, Color.clear, faceColor);
    }
}
