using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{
    public static float turnSpeed = 0.2f;
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed);
    }
}
