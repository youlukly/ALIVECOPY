using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate.AI;
using Ultimate;


[CreateAssetMenu(menuName = "PluggableAI/Actions/AndroidAttackTopDirectioning")]
public class AndroidAttackTopDirectioning : Action
{
    private UIActionManager actionManager;
    private AliveAndroid android;

    public override void ActOnUpdate()
    {
        if (!android.target)
        {
            Vector3 jsDir = actionManager.GetAttackstickDirection();
            Vector3 convert = Vector3.Normalize(new Vector3(jsDir.x,0,jsDir.y));
            android.TopDirectioning(convert.normalized,android.GetData().RotateSpeed);
            return;
        }

        Vector3 targetPosXZ = new Vector3(android.target.transform.position.x, 0.0f, android.target.transform.position.z);
        Vector3 targetDir = targetPosXZ - new Vector3(android.transform.position.x, 0.0f, android.transform.position.z);
        android.TopDirectioning(targetDir.normalized, android.GetData().RotateSpeed);
    }

    public override void Init(Actor actor)
    {
        android = actor as AliveAndroid;
        actionManager = FindObjectOfType<UIActionManager>();
        android.transform.LookAt(android.transform.position + Vector3.forward);
    }
}
