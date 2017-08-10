using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnableAlgorithm : AliveMath
{
    public List<Vector3> FindVertexOfPolygon(MeshFilter spawnableMesh, Vector3 circleCenter, float radius)
    {
        List<Vector3> results = new List<Vector3>();
        for (int i = 0; i < spawnableMesh.mesh.vertices.Length; i++)
        {
            for (int j = i + 1; j < spawnableMesh.mesh.vertices.Length; j++)
            {
                Vector3 xPoint, zPoint;
                xPoint = spawnableMesh.mesh.vertices[i];
                zPoint = spawnableMesh.mesh.vertices[j];

                if (IsInCircle(xPoint, radius, circleCenter) && IsInCircle(zPoint, radius, circleCenter))
                {
                    results.Add(xPoint);
                    results.Add(xPoint);
                }
                else if (IsInCircle(xPoint, radius, circleCenter) || IsInCircle(zPoint, radius, circleCenter))
                {
                    if (IsInCircle(xPoint, radius, circleCenter))
                            results.Add(xPoint);
                    else
                            results.Add(zPoint);

                    for (int k = 0;
                        k < FindContactPointInCircle(
                        GetSlope(xPoint, zPoint),
                        GetYintercept(xPoint, zPoint),
                        radius,
                        circleCenter
                        ).Count;
                        k++)
                        results.Add(FindContactPointInCircle(
                              GetSlope(xPoint, zPoint),
                              GetYintercept(xPoint, zPoint),
                              radius,
                              circleCenter
                              )[k]);


                }
                else
                {
                    for (int k = 0;
                           k < FindContactPointInCircle(
                           GetSlope(xPoint, zPoint),
                           GetYintercept(xPoint, zPoint),
                           radius,
                           circleCenter
                           ).Count;
                           k++)
                        results.Add(FindContactPointInCircle(
                              GetSlope(xPoint, zPoint),
                              GetYintercept(xPoint, zPoint),
                              radius,
                              circleCenter
                              )[k]);
                }

            }
        }

       //RemoveOverlappingVertex(results);

        return results;
    }

    private void RemoveOverlappingVertex(List<Vector3> Vertices)
    {
        int index = 0;
        foreach (Vector3 savedVector in Vertices)
        {
            for (int i = index + 1; i < Vertices.Count; i++)
            {
                if (savedVector != Vertices[i])
                    continue;

                Vertices.RemoveAt(i);
                i--;
            }
            index++;
        }
    }
}
