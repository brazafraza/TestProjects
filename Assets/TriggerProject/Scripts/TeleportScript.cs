using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public GameObject teleportNode;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("s");
        if (other.CompareTag("Player"))
        {
            Vector3 nodeLocation = teleportNode.transform.position;
            other.transform.position = nodeLocation;
            Quaternion nodeRotation = teleportNode.transform.rotation;
            other.transform.rotation = nodeRotation;

            
        }
    }

     void OnDrawGizmos()
    {
        if(teleportNode)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, teleportNode.transform.position);
        }
    }

}
