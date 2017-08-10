using Ultimate;
using UnityEngine;

public class CameraPivot : AliveBehavior
{
    [SerializeField] private float speed;
    private Transform target;

    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public void SetTarget(Transform transform)
    {
        target = transform;
    }

    private void Update()
    {
        if (!target)
            return;
        transform.position = Vector3.Slerp(transform.position, target.transform.position, Ultimate.Time.globalDeltaTime * Speed);
    }
}
