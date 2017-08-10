using UnityEngine;
using Ultimate;

public class Scientist : AliveActor
{
    public override void Init()
    {
        base.Init();
        maxSpeed = 1.0f;
        accel = 1.0f;
        game.sceneManager.currentScene.AddUpdatableInstance(this);
    }
}
