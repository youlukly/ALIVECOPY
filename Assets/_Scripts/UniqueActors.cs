using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class UniqueActors : MonoBehaviour
{
    private static UniqueActors _instance = null;

    public static UniqueActors instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType<UniqueActors>();
                Debug.Log("Auto Instanciated");
                GameObject newInstance = new GameObject("UniqueActors");
                _instance = newInstance.AddComponent<UniqueActors>();
            }

            return _instance;
        }   
    }

    public AliveAndroid android  { private get; set; }

    public AliveSpaceship spaceShip { private get; set; }

    public Actor GetInstance(UniqueActorType type)
    {
        switch (type)
        {
            case UniqueActorType.UniqueActorType_Android:
                return android;
        }

        return null;
    }

    public void SetAndroid(AliveAndroid android)
    {
        this.android = android;
    }
}
