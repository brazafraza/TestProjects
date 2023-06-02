using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public GameObject mainCamera;
    public float runningSpeed = 6;
    int depthOfGroundPiece = 2;

    public GameObject playerObject;

    public GameObject leftPositionMarker;
    public GameObject middlePositionMarker;
    public GameObject rightPositionMarker;

    public int position = 2;

    public float sidestepSpeed = 10;
    public GameObject targetPosition;

     void Start()
    {
        targetPosition = middlePositionMarker;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && position > 1)
        {
            if (position == 2)
            {
                position = 1;
                targetPosition = leftPositionMarker;
            }
            else if (position == 3)
            {
                position = 2;
                targetPosition = middlePositionMarker;
            }
        }

            if (Input.GetKeyDown(KeyCode.D) && position < 3)
            {
                if (position == 2)
                {
                    position = 3;
                targetPosition = rightPositionMarker;
                }
                else if (position == 1)
                {
                    position = 2;
                targetPosition = middlePositionMarker;
                }
            }

        playerObject.transform.position = Vector3.MoveTowards(
            playerObject.transform.position,
            targetPosition.transform.position,
            sidestepSpeed * Time.deltaTime);






            transform.position += Vector3.forward * runningSpeed * Time.deltaTime;

            float cameraXpos = 0;
            float cameraYpos = 1.5f;
            float cameraZpos = this.transform.position.z - 3;
            mainCamera.transform.position = new Vector3(cameraXpos, cameraYpos, cameraZpos);
    }
    
}
