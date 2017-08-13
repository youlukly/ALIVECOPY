using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : AliveActor 
{
    public int resource { get; private set; }
    public bool landed { private set; get; }
    public bool gateOpen { private set; get; }

    private AliveSpaceShipCoreBase core;

    public override void Init()
    {
        maxSpeed = 1.0f;
        accel = 1.0f;

        base.Init();
        transform.position = instanceManager.SpaceShipManager.GetCreatePoint();
        game.sceneManager.currentScene.AddUpdatableInstance(this);
    }

    public void Land()
    {
        Debug.Log("Land Start");
        OnLandingComplete();
    }

    public void OnLandingComplete()
    {
        landed = true;
        agent.enabled = false;
        instanceManager.AndroidManager.CreateAndroid();
        instanceManager.ScientistManager.CreateScientist();
    }

    public void GateOpen()
    {
        Debug.Log("Gate Open Start");
        OnGateOpenComplete();
    }

    public void OnGateOpenComplete()
    {
        instanceManager.Scientist.Init();
        gateOpen = true;
    }

    public void SetCore(AliveSpaceShipCoreBase core)
    {
        this.core = core;
    }

    public override void ManualUpdate()
    {
        base.ManualUpdate();
        if (core == null)
            return;

        core.ManualUpdate();
    }

    public void AccumulateResource(int resource)
    {
        this.resource += resource;
    }

    public void SubtractResource(int resource)
    {
        this.resource -= resource;
    }
}
