using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class Bullet : Actor
{
    [SerializeField] private float deleteDistance = 20.0f;
    [SerializeField] private BulletData data;

    protected Vector3 startPos;

    public BulletData Data
    {
        get
        {
            return data;
        }

        private set
        {
            data = value;
        }
    }

    public virtual void Init(float damage, Vector3 pos, Vector3 direction)
    {

    }

    public override void ManualUpdate()
    {
        if (Vector3.Distance(startPos, transform.position) > deleteDistance)
        {
            UGL.contentsManager.Destroy(gameObject, Tags.Bullets);
            return;
        }

        transform.position += direction.normalized * speed * Ultimate.Time.globalDeltaTime;
    }

    protected void OnTriggerEnter(Collider enterColl)
    {
        if (!enterColl.CompareTag(Tags.Wall))
            return;


        UGL.contentsManager.Destroy(gameObject, Tags.Bullets);
    }
}
