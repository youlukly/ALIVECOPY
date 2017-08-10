using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class AliveEnemy : Actor
{
    public Actor target { private get; set; }

    public EnemyData Data
    {
        get
        {
            return data;
        }
    }


    [SerializeField]private State initState;
    [SerializeField] private EnemyBehaviorBase attack;
    [SerializeField] private EnemyBehaviorBase hit;
    [SerializeField] private EnemyBehaviorBase death;
    [SerializeField] private EnemyData data;

    private GameManager game;
    private float aggro;
    private StateController stateCtrl;
    private Vector3 interpoleDirection;

    private void Awake()
    {
        game = GameManager.instance;
        if (!stateCtrl)
            stateCtrl = GetComponent<StateController>();

        stateCtrl.Init();
	}

    public override void Init()
    {
        base.Init();

        target = UniqueActors.instance.GetInstance(data.FirstTargetType);
        direction = Vector3.forward;
        agent.updateRotation = false;

        maxSpeed = data.Speed;
        accel = data.Accel;

        stateCtrl.TransitionToState(initState);

        game.sceneManager.currentScene.AddUpdatableInstance(this);
    }

    public Vector3 GetDirectionToTarget()
    {
        return target.transform.position - transform.position;
    }

    public override void ManualUpdate()
    {
        Directioning();
        stateCtrl.ManualUpdate();
    }

    private void Directioning()
    {
        interpoleDirection = Vector3.Slerp(interpoleDirection, direction, Ultimate.Time.globalDeltaTime * Data.RotateSpeed);
        transform.LookAt(transform.position + interpoleDirection);
    }

    public void Attack()
    {
        Debug.Log("Attack");
        if (!attack)
            return;
        attack.Excute();
        attack.ExcuteFX();
    }

    public void SetTarget(Actor target)
    {
        if (this.target == target)
            return;

        this.target = target;
    }

    public void AddAggroRate(float aggro)
    {
        if (aggro >= 100.0f)
            return;

        aggro += aggro;

        if(aggro > 100.0f)
            aggro = 100.0f;
    }

    public void SubtractAggroRate(float aggro)
    {
        if (aggro <= -100.0f)
            return;

        this.aggro -= aggro;

        if (aggro < -100.0f)
            aggro = -100.0f;
    }
}
