using UnityEngine;
using Ultimate;

public enum UniqueActorType
{
    UniqueActorType_Android,
}

public class InstanceManager : MonoBehaviour
{
    private static InstanceManager _instance = null;

    public static InstanceManager instance
    {
        get
        {
            if (!_instance)
                _instance = FindObjectOfType<InstanceManager>();
            if (!_instance)
            {
                Debug.Log("Auto Instantiated");
                GameObject newInstance = new GameObject("InstanceManager");
                _instance = newInstance.AddComponent<InstanceManager>();
            }

            return _instance;
        }
    }

    public Actor GetInstance(UniqueActorType type)
    {
        switch (type)
        {
            case UniqueActorType.UniqueActorType_Android:
                return android;
        }

        return null;
    }

    public AliveAndroid Android
    {
        set
        {
            android = value;
        }
        get
        {
            if (!android)
            {
                if (!AndroidManager.android)
                {
                    Debug.LogError("Not Set Android");
                    return null;
                }

                android = AndroidManager.android;
            }

            return android;
        }
    }

    public SpaceShip SpaceShip
    {
        get
        {
            if (!SpaceShip1)
            {
                if (!SpaceShipManager.spaceShip)
                {
                    return null;
                }

                SpaceShip1 = SpaceShipManager.spaceShip;
            }

            return SpaceShip1;
        }

        set
        {
            SpaceShip1 = value;
        }
    }

    public Scientist Scientist
    {
        get
        {
            if (!scientist)
            {
                if (!scientistManager.scientist)
                {
                    return null;
                }

                scientist = scientistManager.scientist;
            }
            return scientist;
        }
    }

    public AndroidManager AndroidManager
    {
        get
        {
            return androidManager;
        }
    }

    public ScientistManager ScientistManager
    {
        get
        {
            return scientistManager;
        }
    }

    public SpaceShipManager SpaceShipManager
    {
        get
        {
            return spaceShipManager;
        }
    }

    public SpaceShip SpaceShip1
    {
        get
        {
            return spaceShip;
        }

        set
        {
            spaceShip = value;
        }
    }

    public BulletManager BulletManager
    {
        get
        {
            return bulletManager;
        }

        set
        {
            bulletManager = value;
        }
    }

    private AndroidManager androidManager;
    private AliveAndroid android;
    private ScientistManager scientistManager;
    private Scientist scientist;
    private SpaceShipManager spaceShipManager;
    private SpaceShip spaceShip;
    private BulletManager bulletManager;


    public void Init()
    {
        androidManager = FindObjectOfType<AndroidManager>();
        spaceShipManager = FindObjectOfType<SpaceShipManager>();
        scientistManager = FindObjectOfType<ScientistManager>();
        bulletManager = FindObjectOfType<BulletManager>();

        if (!AndroidManager || !SpaceShipManager || !ScientistManager)
        {
            Debug.LogError("Not Found UniqueActor Managers");
            return;
        }

        androidManager.Init();
        spaceShipManager.Init();
        scientistManager.Init();
        bulletManager.Init();
    }
}
