using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayAnimation : MonoBehaviour
{
    public Animator animator;
    public float interactDelay = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Invoke("PlayAnimation", interactDelay);

        }
    }

    private void PlayAnimation()
    {
        animator.SetTrigger("play");
    }
}