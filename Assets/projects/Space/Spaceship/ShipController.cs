using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed = 20;
    public float rollWeight = 2;
    public float pitchWeight = 2;
    public float thrust = 5;

    public float maxThrust = 100;
    public float minThrust = 10;
    public Quaternion startingRotation;
    public Vector3 startingPosition;


     void Start()
    {
        startingRotation = transform.rotation;
        startingPosition = transform.position;
    }

    void ResetPlayer()
    {
        transform.position = startingPosition;
        transform.rotation = startingRotation;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    void OnCollisionEnter()
    {
        ResetPlayer();
    }


    void Update()
    {

        if (transform.position.y < -50 || transform.position.y > 300)
        {
            ResetPlayer();
        }

        if (transform.position.x < -300 || transform.position.x > 300)
        {
            ResetPlayer();
        }

        if (transform.position.z < -300 || transform.position.z > 300)
        {
            ResetPlayer();
        }


        float roll = -rollWeight * Input.GetAxis("Horizontal");
        float pitch = pitchWeight * Input.GetAxis("Vertical");
        Vector3 Rotation = new Vector3(pitch, 0, roll);

        transform.Rotate(Rotation);
        if (Input.GetButton("Jump"))
        {
            speed = speed + thrust;

            if (speed > maxThrust)
            {
                speed = maxThrust;
            }
        }
        else
        {
            speed = speed - thrust;
            if (speed < minThrust)
            {
                speed = minThrust;
            }
        }
       

        transform.position += transform.forward * speed * Time.deltaTime;


    }
}
