using System;
using System.Collections.Generic;
using Ultimate;
using UnityEngine;

public class UGLContentsManager : MonoBehaviour
{
    [Serializable]
    public struct Container
    {
        public string name;
        public GameObject prefab;
        public int count;
    }

   [SerializeField] public List<Container> containers;

    private void Awake()
    {
        UGL.ProvideContentsManager();

        foreach (var VARIABLE in containers)
        {
            UGL.contentsManager.CreateInstancePool(new InstancePool(VARIABLE.name, VARIABLE.prefab, VARIABLE.count));
        }
    }

    public Container GetContainer(string name)
    {
        foreach (var VARIABLE in containers)
        {
            if (VARIABLE.name == name)
                return VARIABLE;
        }

        return new Container();
    }
}
