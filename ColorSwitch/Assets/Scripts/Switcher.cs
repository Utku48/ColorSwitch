using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{

    public float turnSpeed = 75f;
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed);
    }

}
