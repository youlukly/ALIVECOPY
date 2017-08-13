using UnityEngine;

[CreateAssetMenu(menuName ="ALIVE/Data/Bullet")]
public class BulletData : ScriptableObject
{
    [SerializeField] private BulletType type;
    [SerializeField] private float damage;
    [SerializeField] private float speed;

    public BulletType Type
    {
        get
        {
            return type;
        }

        set
        {
            type = value;
        }
    }


    public float Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }

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


}
