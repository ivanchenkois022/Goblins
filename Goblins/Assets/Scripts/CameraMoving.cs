using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    private float speedPosition = 0.3f;
    private float speedRotation = 4.0f;
    [NonSerialized] public Vector3 positionPoint = new Vector3(0f, 1.08f, -0.09f);
    private Vector3 target = new Vector3(0f, 0.81f, 0f);
    
    private void Update()
    {
        move();
    }

    private void move()
    {
        float step = speedPosition * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, positionPoint, step);

        float singleStep = speedRotation * Time.deltaTime;
        Vector3 direction = (target - transform.position).normalized;
        Quaternion _rotate = Quaternion.LookRotation(new Vector3(direction.x, direction.y, direction.z));
        transform.rotation = Quaternion.Lerp(transform.rotation, _rotate, singleStep);
    }
}