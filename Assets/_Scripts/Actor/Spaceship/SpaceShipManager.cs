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
        public Vector3 lanPoint;
        public Vector3 scientistCreatePoint;
        public Vector3 androidCreatePoint;
        public Vector3 getOffPoint;
    }

    public SpaceShip spaceShip { private set; get; }
}
