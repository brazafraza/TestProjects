using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up;
    public float rotationSpeed = 1;
    void Update()
    {
        transform.Rotate(rotationAxis * Time.deltaTime * rotationSpeed); 
    }
}
