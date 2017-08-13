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
        public Vector3 scientistCreatePoint;
        public Vector3 androidCreatePoint;
        public Vector3 getOffPoint;
    }

    public SpaceShip spaceShip { private set; get; }

    [SerializeField] GameObject spaceShipPrefab;
    [SerializeField] private StartPoint[] startPoints;

    private StartPoint selectedPoint;

    public void Init()
    {
        selectedPoint = GetRandomStartPoint();
    }

    public void CreateSpaceShip()
    {
        spaceShip = UGL.contentsManager.CreateInstance(spaceShipPrefab).GetComponent<SpaceShip>();
    }

    public Vector3 GetScientistCreatePoint()
    {
        return selectedPoint.scientistCreatePoint;
    }

    public Vector3 GetAndroidCreatePoint()
    {
        return selectedPoint.androidCreatePoint;
    }

    public Vector3 GetgetOffPoint()
    {
        return selectedPoint.getOffPoint;
    }

    public Vector3 GetCreatePoint()
    {
        return selectedPoint.createPoint;
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
