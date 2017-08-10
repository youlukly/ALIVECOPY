using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class UGLSpawner : MonoBehaviour
{
    [SerializeField] public float cycle;
    [SerializeField] public bool autoStart;

    [SerializeField] [HideInInspector] private string[] targetNames;


    private List<UGLContentsManager.Container> targetContainers = new List<UGLContentsManager.Container>();

    private UGLContentsManager contentsManager;
   
    private float nowTime = 0.0f;

    public bool spawning { private set; get; }

    public void SpawnStart()
    {
        spawning = true;
    }

    public void SpawnStop()
    {
        spawning = false;
    }

    private void Awake()
    {
        contentsManager = FindObjectOfType<UGLContentsManager>();
        if (!contentsManager)
        {
            Debug.LogError("Need ContentsManager");
            return;
        }

        nowTime = cycle;

        foreach (var VARIABLE in contentsManager.containers)
        {
        }

        if (autoStart)
            SpawnStart();
    }

    private void OnDrawGizmos()
    {
        Debug.Log(targetContainers.Count);
        foreach (var VARIABLE in targetContainers)
        {
            MeshRenderer meshRenderer = VARIABLE.prefab.GetComponentInChildren<MeshRenderer>();
            Material mat = meshRenderer.material;
            Mesh mesh = VARIABLE.prefab.GetComponentInChildren<Mesh>();

            mat.SetPass(0);
            Graphics.DrawMeshNow(mesh, Matrix4x4.TRS(transform.position, transform.rotation, transform.localScale));
        }
    }

    private void Spawn()
    {
        Debug.Log("Spawn");
    }

    private void Update()
    {
        if(!spawning)
            return;

        if (nowTime <= 0.0f)
        {
            nowTime = cycle;
            Spawn();
            return;
        }

        nowTime -= Time.deltaTime;
    }
}
