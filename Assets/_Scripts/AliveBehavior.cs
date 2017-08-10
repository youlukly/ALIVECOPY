using Ultimate;
using UnityEngine;

public class AliveBehavior : MonoBehaviour
{
    protected ContentsManager contents { private set; get; }
    protected GameManager game { private set; get; }
    protected InstanceManager instanceManager { private set; get; }

    protected virtual void Awake()
    {
        game = GameManager.instance;
        instanceManager = InstanceManager.instance;
        contents = UGL.contentsManager;
    }
}
