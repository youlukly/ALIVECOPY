using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ultimate;

public class UGLThirdPersonCamera : MonoBehaviour
{
    [SerializeField] private Transform pivot;
    public float speed { set; get; }
    public float elevation;
    public float azimuth;

    public SphericalCoordinate sphericalCoordinate { private set; get; }

    public void SetPivot(Transform transform)
    {
        pivot = transform;
    }

    private void Awake()
    {
        sphericalCoordinate = new SphericalCoordinate(transform.position, 5.0f, 5.0f, 10.0f, 0.0f, 85.0f);
    }

    private void Update()
    {   
        if (!pivot)
            return;
        sphericalCoordinate.Elevation = elevation * Mathf.Deg2Rad;
        sphericalCoordinate.Azimuth = azimuth * Mathf.Deg2Rad;
        //        sphericalCoordinate.Rotate(Input.GetAxis("Mouse X") , Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse ScrollWheel") , 1.0f);
        transform.position = sphericalCoordinate.ToCartesian + pivot.position;
        transform.LookAt(pivot);
    }
}
