using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;
using System;

[RequireComponent(typeof(SpaceShipManager))]
public class PlaySceneManager : SceneHandlerBase
{
    private GameManager game = null;
    public UGLThirdPersonCamera cam { private set; get; }
    public UIActionManager ui { private set; get; }
    public SpaceShipManager spaceShipManager { private set; get; }
    public AndroidManager androidManager { private set; get; }
    public ScientistManager scientistManager { private set; get; }
    public EnemyManager enemyManager { private set; get; }

    public override void OnEnterScene()
    {
        Debug.Log("EnterScene");
        game = GameManager.instance;
        cam = FindObjectOfType<UGLThirdPersonCamera>();
        ui = FindObjectOfType<UIActionManager>();
        spaceShipManager = GetComponent<SpaceShipManager>();
        androidManager = GetComponent<AndroidManager>();
        scientistManager = GetComponent<ScientistManager>();
        enemyManager = GetComponent<EnemyManager>();

        enemyManager.Init();
        spaceShipManager.Init();
        androidManager.Init();
        scientistManager.Init();

        // contents.CreateTestEnemy();
        //cam.pivot = android.transform;

        ui.Init();
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


}
