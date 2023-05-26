using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SphereScript : MonoBehaviour
{
    public Vector3 teleportPosition = new Vector3(0, 0, 10);
    public float maxFallHeight = -20;
    void Update()
    {
        if (transform.position.y < maxFallHeight)
        {
            transform.position = teleportPosition;
        }
    }
}