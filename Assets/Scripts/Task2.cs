using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Task2 : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float angleValue;
   

    private void OnDrawGizmos()
    {
        Vector3 directionToTarget = (target.position - transform.position).normalized;
        Vector3 upDirection = transform.up;
        float cosAngle = Vector3.Dot(directionToTarget, upDirection);
        if (cosAngle > angleValue)
        {
            Gizmos.color = Color.yellow;
        }
        else
        {
            Gizmos.color = Color.blue;
        }
        Gizmos.DrawRay(transform.position, upDirection);
    }
}
