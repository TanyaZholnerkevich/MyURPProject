using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float radius;
    private void OnDrawGizmos()
    {
        Vector3 distance = target.position - transform.position;
        float lengthSqr = distance.x * distance.x + distance.y * distance.y;
        double length = Math.Sqrt(lengthSqr);
        if (radius > length)
        {
            Handles.color = Color.blue;
        }
        else
        {
            Handles.color = Color.yellow;
        }
        Handles.DrawWireDisc(transform.position, Vector3.forward, radius);
    }
}
