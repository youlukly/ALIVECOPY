using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RimRectSpawn : SpawnBase
{
    private Vector3 center;
    private float row;
    private float col;

    public RimRectSpawn(MeshFilter spawnableMesh, Vector3 center, float row, float col) : base(spawnableMesh)
    {
        this.center = center;
        this.row = row;
        this.col = col;
    }

    public override void Spawn()
    {
        Vector3 tempPoint = SpawnPointSetting(center, row, col);
        if (SpawnableCheck(tempPoint))
        {
            GameObject tempEnemy = new GameObject();
            tempEnemy.transform.position = tempPoint;
            Debug.Log("Spawn");
        }
    }

    private bool SpawnableCheck(Vector3 spawnPoint)
    {
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

    private Vector3 SpawnPointSetting(Vector3 spawnPoint, float rangeX, float rangeZ)
    {
        int priority = Random.Range(0, 2);
        Vector3 randomVector =new Vector3();
        if (priority == 0)
        {
            int rowRandom = Random.Range(0, 2);
            randomVector = new Vector3(
         spawnPoint.x +
         rangeX / 2 - (rangeX * rowRandom),
         0,         
         spawnPoint.z +
         Random.Range(-rangeZ / 2,rangeZ / 2)
         );
        }
        else if (priority == 1)
        {
            int colRandom = Random.Range(0, 2);
            randomVector = new Vector3(
        spawnPoint.x +
         Random.Range(-rangeX / 2, rangeX / 2),
         0,
          spawnPoint.z +
        rangeZ / 2 - (rangeZ * colRandom)
         );
        }
        return randomVector;
    }
}
