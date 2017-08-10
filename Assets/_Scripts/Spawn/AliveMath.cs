using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveMath
{
    public List<Vector3> FindContactPointInCircle(float slope, float yIntercept, float radius, Vector3 circleCenter)
    {
        List<Vector3> results = new List<Vector3>();
        float a, b;
        float sqrRange;
        sqrRange = Mathf.Pow(radius, 2);
        a = circleCenter.x;
        b = circleCenter.z;

        float xSqrCoefficient = slope * slope + 1;
        float xCoefficient = 2 * (-a + slope - b * slope);
        float constant = a * a + yIntercept * yIntercept - 2 * yIntercept * b + b * b - sqrRange;

        int D = 0;
        D = Discriminant(
            xSqrCoefficient,
            xCoefficient,
            constant
            );

        if (D == 2)
        {
            float x1, x2, y1, y2;

            x1 = (-1 * xCoefficient + Mathf.Sqrt(xCoefficient * xCoefficient - 4 * xSqrCoefficient * constant)) / 2 * xSqrCoefficient;
            y1 = slope * x1 + yIntercept;
            x2 = (-1 * xCoefficient - Mathf.Sqrt(xCoefficient * xCoefficient - 4 * xSqrCoefficient * constant)) / 2 * xSqrCoefficient;
            y2 = slope * x1 + yIntercept;

            Vector3 result = new Vector3(x1, 0, y1);
            results.Add(result);
            result = new Vector3(x2, 0, y2);
            results.Add(result);
        }
        else if (D == 1)
        {
            float x, y;
            x = (-1 * xCoefficient + Mathf.Sqrt(xCoefficient * xCoefficient - 4 * xSqrCoefficient * constant)) / 2 * xSqrCoefficient;
            y = slope * x + yIntercept;

            Vector3 result = new Vector3(x, 0, y);
            results.Add(result);
        }
        else if (D == 0)
        {
            Debug.Log("there is no contact point");
        }

        return results;
    }

    public float GetYintercept(Vector3 point1, Vector3 point2)
    {
        List<Vector3> results = new List<Vector3>();
        float p1x, p1y, p2x, p2y;
        p1x = point1.x;
        p1y = point1.z;
        p2x = point2.x;
        p2y = point2.z;

        float a, b;
        a = (p2y - p1y) / (p2x - p1x);
        b = p2y - a * p2x;

        return b;
    }

    public float GetSlope(Vector3 point1, Vector3 point2)
    {
        List<Vector3> results = new List<Vector3>();
        float p1x, p1y, p2x, p2y;
        p1x = point1.x;
        p1y = point1.z;
        p2x = point2.x;
        p2y = point2.z;

        float a;
        a = (p2y - p1y) / (p2x - p1x);

        return a;
    }

    public bool IsInCircle(Vector3 point, float radius, Vector3 circleCenter)
    {
        float sqrRange;
        sqrRange = Mathf.Pow(radius, 2);
        float x, y, a, b;
        x = point.x;
        y = point.z;
        a = circleCenter.x;
        b = circleCenter.z;
        return sqrRange >= (x - a) * (x - a) + (y - b) * (y - b);
    }

    public int Discriminant(float xSqrCoefficient, float xCoefficient, float constant)
    {
        float result;
        result = Mathf.Pow(xCoefficient, 2) - 4 * xSqrCoefficient * constant;
        if (result > 0.0f)
            return 2;
        else if (result == 0.0f)
            return 1;
        else
            return 0;
    }
}
