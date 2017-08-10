using Ultimate;
using UnityEngine;

public class ScientistManager : AliveBehavior
{
    [SerializeField] private GameObject scientistPrefab;

    public Scientist scientist { private set; get; }

    public void Init()
    {

    }

    public void CreateScientist()
    {
        if (!scientistPrefab)
        {
            return;
        }
        scientist = UGL.contentsManager.CreateInstance(scientistPrefab).GetComponent<Scientist>();
        scientist.transform.position = instanceManager.SpaceShipManager.GetScientistCreatePoint();
    }

}
