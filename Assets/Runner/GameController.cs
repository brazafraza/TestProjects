using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public GameObject groundPiece1;
   // public GameObject groundPiece2;
   // public GameObject groundPiece3;

    public int groundPieceCounter = 0;
    public int depthOfGroundPiece = 2;

    public float playerPositionCounter = 0;
    public GameObject player;

    public List<GameObject> groundPieces = new List<GameObject>();

    void BuildGround()
    {
        Instantiate(groundPieces[Random.Range(0, groundPieces.Count)],
            Vector3.forward * groundPieceCounter * depthOfGroundPiece,
            Quaternion.identity);
            groundPieceCounter++;




       /* GameObject groundPieceToPlace = null;
        int randomPiece = Random.Range(0, 3);
        if (randomPiece == 0)
        {
            groundPieceToPlace = groundPiece1;
        }
        else if (randomPiece == 1)
        {
            groundPieceToPlace = groundPiece2;
        }
        else if (randomPiece ==2)
        {
            groundPieceToPlace = groundPiece3;
        }


        Instantiate(groundPieceToPlace, Vector3.forward * groundPieceCounter * depthOfGroundPiece, Quaternion.identity);
        groundPieceCounter++; */
    }

     void Update()
    {
        if (player.transform.position.z > playerPositionCounter)
        {
            playerPositionCounter += depthOfGroundPiece;

            BuildGround();
        }
    }


    void Start()
    {
            for (int i = 0; i < 40; i++)
            {
                BuildGround();

            }


    }

}
