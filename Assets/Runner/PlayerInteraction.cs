using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hurdle")
        {
            Debug.Log("You die");
        }

        if (other.tag == "Pickup")
        {
            Destroy(other.gameObject);
        }
    }
}