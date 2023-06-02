using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGrenade : MonoBehaviour
{
    public GameObject grenadeLaunchPoint;
    public GameObject flowerGrenade;
    public float launchPower = 2;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //create nade
            GameObject GO = Instantiate(flowerGrenade,
                grenadeLaunchPoint.transform.position, Quaternion.identity) as GameObject;

            //adding froce to the grenade rigidbody
            GO.GetComponent<Rigidbody>().AddForce(
                grenadeLaunchPoint.transform.forward * launchPower, ForceMode.Impulse);
        }


    }
}
