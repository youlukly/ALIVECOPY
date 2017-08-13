using UnityEngine;
using Ultimate;
using System;

public class PlaySceneManager : SceneHandlerBase
{
    private GameManager game = null;
    public AlivePlaySceneCamera cam { private set; get; }
    public UIActionManager ui { private set; get; }
    public EnemyManager enemyManager { private set; get; }

    private InstanceManager instanceManager;

    public override void OnEnterScene()
    {
        Debug.Log("EnterScene");
        game = GameManager.instance;
        game.SetPlayScene(this);
        cam = FindObjectOfType<AlivePlaySceneCamera>();
        ui = FindObjectOfType<UIActionManager>();
        enemyManager = GetComponent<EnemyManager>();
        instanceManager = InstanceManager.instance;

        GoToReady();
    }

    public void GoToReady()
    {
        OnReady();
    }

    public void GoToPlay()
    {
        OnPlay();
    }

    public void GoToGameOver()
    {
        OnGameOver();
    }

    public override void OnExitScene()
    {
        Debug.Log("ExitScene");
    }

    protected override void ManualUpdate()
    {
        base.ManualUpdate();
        game.inputManager.ManualUpdate();
    }

    private void OnGameOver()
    {

    }

    private void OnPlay()
    {
        ui.Init();
        instanceManager.Android.Init();
        cam.SetAndroidPivot();
    }

    private void OnReady()
    {
        enemyManager.Init();
        instanceManager.Init();

        instanceManager.SpaceShipManager.CreateSpaceShip();
        instanceManager.SpaceShip.Init();
        cam.SetSpaceShipPivot();
    }

}
