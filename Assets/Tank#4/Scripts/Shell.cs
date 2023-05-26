using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public int damage = 20;
    void Start()
    {
        Destroy(this.gameObject, 4f);
    }

    // Update is called once per frame


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<TankController>().TakeDamage(damage);
        
        }
        Destroy(this.gameObject);
    }
    void Update()
    {
        
    }
}
