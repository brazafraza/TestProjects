using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

[RequireComponent(typeof(TriggerDisplay))]
public class TriggerObjectPickup : MonoBehaviour
{
    public string objectName = "This thing";

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.FindObjectOfType<UIController>().
            //GameObject.FindObjectOfType<InventoryController>().AddItem(objectName);    
            gameObject.SetActive(false);
        }
    }
}