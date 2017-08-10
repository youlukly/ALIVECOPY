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
        base.Init();
        transform.position = instanceManager.space
    }

    public void Land()
    {

    }

    public void OnLandingComplete()
    {

    }

    public void GateOpen()
    {

    }

    public void OnGateOpenComplete()
    {

    }

    public void SetCore(AliveSpaceShipCoreBase core)
    {
    }

    public override void ManualUpdate()
    {
        base.ManualUpdate();
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
