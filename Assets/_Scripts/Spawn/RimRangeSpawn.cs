using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RimRangeSpawn : SpawnBase
{
    private Vector3 center;
    private float range;

    public RimRangeSpawn(MeshFilter spawnableMesh, Vector3 center, float range) : base(spawnableMesh)
    {
        this.center = center;
        this.range = range;
    }
    public override void Spawn()
    {
        Vector3 tempPoint = SpawnPointSetting(center, range);
        if (SpawnableCheck(tempPoint))
        {
            GameObject tempEnemy = new GameObject();
            tempEnemy.transform.position = tempPoint;
            Debug.Log("Spawn");
        }
    }

    private bool SpawnableCheck(Vector3 spawnPoint)
    {
        Mesh mesh = new Mesh();
        Ray ray = new Ray(spawnPoint + Vector3.up, Vector3.down);
        float rayDistance = 1.0f;
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if (hit.collider.gameObject.GetComponent<MeshFilter>() == spawnableMesh)
            {
                return true;
            }
            else
            {
                Debug.LogWarning("there's some Obstacles in spawn area. nothing has spawned.");
                return false;
            }
        }
        else
        {
            Debug.LogWarning("no meshfilter detected in current spawn point.");
            return false;
        }
    }

    private Vector3 SpawnPointSetting(Vector3 spawnPoint, float range)
    {
        float angle = Random.Range(0.0f,360.0f);
        Vector3 tempPos = spawnPoint + new Vector3(Mathf.Cos(angle) * range,0,Mathf.Sin(angle) * range);
        return tempPos;
    }

}
