using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class EnemyManager : MonoBehaviour
{
    public void Init()
    {
    }

    public void CreateTestEnemy()
    {
        UGL.contentsManager.CreateInstance<AliveEnemy>("Enemies").Init();
    }

}
