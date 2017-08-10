using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Ultimate;

public class SpaceShipManager : MonoBehaviour
{
    [Serializable]
    public struct StartPoint
    {
        public Vector3 createPoint;
        public Vector3 landPoint;
    }

    public AliveSpaceship spaceShip { private get; set; }

    [SerializeField] private GameObject spaceShipPrefab;
    [SerializeField] private StartPoint[] startPoints;

    private StartPoint selectedPoint;

    public void Init()
    {
        selectedPoint = GetRandomStartPoint();
    }

    public void CreateSpaceShip()
    {
        spaceShip = UGL.contentsManager.CreateInstance(spaceShipPrefab).GetComponent<AliveSpaceship>();
        spaceShip.Init();
        spaceShip.Land(GetLandingPoint());
    }

    public Vector3 GetLandingPoint()
    {
        return selectedPoint.landPoint;
    }

    private StartPoint GetRandomStartPoint()
    {
        int index = UnityEngine.Random.Range(0,startPoints.Length);
        return startPoints[index];
    }
}
