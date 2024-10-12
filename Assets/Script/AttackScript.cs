
using System.Collections;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    Animator anim;
    CapsuleCollider attackCollider;

    void Start()
    {
        anim = GetComponent<Animator>();
        attackCollider = GetComponentInChildren<CapsuleCollider>();
        attackCollider.enabled = false; 
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("attack", true);
            attackCollider.enabled = true;  
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            anim.SetBool("attack", false);
            attackCollider.enabled = false; 
        }
    }
}
//ghj