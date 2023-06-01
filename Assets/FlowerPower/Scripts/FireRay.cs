using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FireRay : MonoBehaviour
{
    public GameObject raycastMarker = null;

    public int ammoCount = 100;
    public int clipSize = 15;
    public int clipCount = 5;

    public TMP_Text ammoText;
    public TMP_Text clipText;

    public float timeBetweenBullets = 0.2f;
    private bool canShoot = true;

    private void ResetShooting()
    {
        canShoot = true;
    }


    private void Reload()
    {
        ammoCount += clipCount;

        if (ammoCount > clipSize)
        {
            clipCount = clipSize;
            ammoCount -= clipSize;
        }

        else
        {
            clipCount = ammoCount;
            ammoCount = 0;
        }

        UpdateText();
    }


    void Update()
    {
        //
        RaycastHit hit;

        float distanceOfRay = 100;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distanceOfRay))
        {
            // Debug.Log(hit.transform.name);

            if (Input.GetKeyDown(KeyCode.R))
            {
                Reload();
            }
        }

        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * distanceOfRay);



        if (Input.GetMouseButton(0))
        {

            //if clip empty dont fire
            if (clipCount <=0)
            {
                return;
            }

            if (canShoot == false)
            {
                return;
            }

            canShoot = false;
            Invoke("ResetShooting", timeBetweenBullets);


            clipCount--;
            UpdateText();

            raycastMarker.transform.position = hit.point;
            raycastMarker.GetComponentInChildren<ParticleSystem>().Play();

            //Debug.Log(hit.point);

            //move object
            //hit.transform.position = hit.transform.position + Vector3.up;

            //scale object
            //hit.transform.localScale = hit.transform.localScale * 0.9f;

            //deactivate object
           // hit.transform.gameObject.SetActive(false);

            //destroy object
           // Destroy(hit.transform.gameObject);

            //colour object
           // hit.transform.gameObject.GetComponent<Renderer>().material.color =
             //   new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        }


    }

    private void UpdateText()
    {
        ammoText.text = ammoCount.ToString();
        clipText.text = clipCount.ToString();
    }

    void Start()
    {
        UpdateText();
    }

}
