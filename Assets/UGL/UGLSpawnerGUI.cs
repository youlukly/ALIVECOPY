using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CanEditMultipleObjects]
[CustomEditor(typeof(UGLSpawner))]
public class UGLSpawnerGUI : Editor
{
    private UGLSpawner spawner;
    private UGLContentsManager contentsManager;

    private static readonly Dictionary<string, bool> selected = new Dictionary<string, bool>();

    private void OnEnable()
    {
        spawner = target as UGLSpawner;
        Load();
    }

    private void Load()
    {
        contentsManager = FindObjectOfType<UGLContentsManager>();
        if (!contentsManager)
        {
            Debug.LogError("Not Found ContentsManager");
            return;
        }

        foreach (var VARIABLE in contentsManager.containers)
        {
            if(!selected.ContainsKey(VARIABLE.name))
                selected.Add(VARIABLE.name , false);
        }

        foreach (var VARIABLE in selected)
        {
            if (!contentsManager.containers.Contains(contentsManager.GetContainer(VARIABLE.Key)))
                selected.Remove(VARIABLE.Key);
        }
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        if (!contentsManager)
            return;

        List<KeyValuePair<string , bool>> list = selected.ToList();

        foreach (var VARIABLE in list)
        {
            selected[VARIABLE.Key] = EditorGUILayout.Toggle(VARIABLE.Key, selected[VARIABLE.Key]);
//            if (selected[VARIABLE.Key] &&spawner.targetContainers.Contains(contentsManager.GetContainer(VARIABLE.Key)))
//            {
//                spawner.targetContainers.(contentsManager.GetContainer(VARIABLE.Key));
//            }
        }

        serializedObject.ApplyModifiedProperties();
    }
}
