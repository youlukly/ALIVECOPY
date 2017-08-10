using Ultimate;

public class GameManager
{
    private static readonly GameManager _instance = new GameManager();

    public static GameManager instance
    {
        get{return _instance;}
    }

    public SceneManager sceneManager { private set; get; }
    public InputManager inputManager { private set; get; }
    public AliveAccount account { private set; get; }

    private GameManager()
    {
        UnityEngine.Debug.Log("Test");
        sceneManager = UGL.sceneManager;
        inputManager = UGL.inputManager;

        account = new AliveAccount();
    }
}
