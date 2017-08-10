using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] AliveSpawnManager spawnManager;
    [SerializeField] AliveSpawnerBase spawner;
    [SerializeField] MeshFilter mesh;
    [SerializeField] float range;
    [SerializeField] Vector3 center;
    [SerializeField] Vector3 testPoint;

    AliveMath matha = new AliveMath();
    SpawnableAlgorithm algorithm = new SpawnableAlgorithm();
    List<Vector3> testList = new List<Vector3>();

    private void Awake()
    {
        //for(int i=0; i<= 10; i ++)
        //spawnManager.Spawn(spawner);

        testList = algorithm.FindVertexOfPolygon(mesh, center, range);
        Debug.Log(testList.Count);
        for (int i = 0; i < testList.Count; i++)
        {
            GameObject gm = new GameObject();
            gm.transform.position = testList[i];
        }



        //Debug.Log(matha.FindContactPointInCircle);
    }

    private void OnDrawGizmos()
    {
        UnityEditor.Handles.color = new Color(1, 1, 0.1f, 0.25f);
        UnityEditor.Handles.DrawSolidDisc(center, Vector3.up, range);
    }
}
