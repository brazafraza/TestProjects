using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    public float upwardsThrust = 40;
    public float rotationalThrust = 5f;

    // Update is called once per frame
    void Update()
    {

         if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * upwardsThrust);
        }

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(transform.right * rotationalThrust);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(transform.right * -rotationalThrust);
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(transform.forward * rotationalThrust);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(transform.forward * -rotationalThrust);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(transform.up * -rotationalThrust);
        }

        if (Input.GetKey(KeyCode.E))
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(transform.up * rotationalThrust);
        } 




    }
}
