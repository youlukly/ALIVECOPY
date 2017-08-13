using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class UGLThirdPersonCamera : MonoBehaviour
{
    public float elevation;
    public float azimuth;

    public SphericalCoordinate sphericalCoordinate { private set; get; }

    private CameraPivot pivot;

    public void SetPivot(Transform transform)
    {
        pivot.SetTarget(transform);
    }

    private void Awake()
    {
        pivot = FindObjectOfType<CameraPivot>();
        sphericalCoordinate = new SphericalCoordinate(transform.position, 5.0f, 5.0f, 10.0f, 0.0f, 85.0f);
    }

    private void Update()
    {   
        if (!pivot)
            return;
        sphericalCoordinate.Elevation = elevation * Mathf.Deg2Rad;
        sphericalCoordinate.Azimuth = azimuth * Mathf.Deg2Rad;
        //        sphericalCoordinate.Rotate(Input.GetAxis("Mouse X") , Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse ScrollWheel") , 1.0f);
        transform.position = sphericalCoordinate.ToCartesian + pivot.transform.position;
        transform.LookAt(pivot.transform);
    }
}
