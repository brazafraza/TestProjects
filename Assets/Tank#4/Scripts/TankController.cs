using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float forwardSpeed = 0.1f;
    public float backwardSpeed = 0.08f;
    public float rotationalSpeed = 2f;

    public float turretRotationalSpeed = 1.5f;

    public float shellSpeed = 200;

    public GameObject shellPrefab;

    public Transform shellSpawnPoint;

    public GameObject turret;



    //controls
    public KeyCode forwardsKey = KeyCode.W;
    public KeyCode backwardsKey = KeyCode.S;
    public KeyCode rotateLeftKey = KeyCode.A;
    public KeyCode rotateRightKey = KeyCode.D;
    public KeyCode rotateTurretLeftKey = KeyCode.Q;
    public KeyCode rotateTurretRightKey = KeyCode.E;
    public KeyCode fireKey = KeyCode.Space;



    //health
    public int health = 100;


    public void TakeDamage(int damageToTake)
    {
        health = health - damageToTake;
    }

    void Update()
    {

        if (health<= 0)
        {
            return;
        }



        if (Input.GetKeyDown(fireKey))
        {
            GameObject GO = Instantiate(shellPrefab, shellSpawnPoint.position, Quaternion.identity) as GameObject;
            GO.GetComponent<Rigidbody>().AddForce(turret.transform.forward * shellSpeed, ForceMode.Impulse);
        }


        //rotate the nozzle


        if (Input.GetKey(rotateTurretLeftKey))
        {
            turret.transform.Rotate(0, -turretRotationalSpeed, 0, Space.Self);
        }

        if (Input.GetKey(rotateTurretRightKey))
        {
            turret.transform.Rotate(0, turretRotationalSpeed, 0, Space.Self);
        }


        //tank controls


        if (Input.GetKey(forwardsKey))
        {
            transform.position = transform.position + transform.forward * forwardSpeed;
        }

        if (Input.GetKey(backwardsKey))
        {
            transform.position = transform.position + transform.forward * -backwardSpeed;
        }

        if (Input.GetKey(rotateLeftKey))
        {
            transform.Rotate(transform.up * -rotationalSpeed);
        }

        if (Input.GetKey(rotateRightKey))
        {
            transform.Rotate(transform.up  * rotationalSpeed);
        }
    }
}
