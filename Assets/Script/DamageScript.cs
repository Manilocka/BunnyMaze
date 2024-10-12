// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class DamageScript : MonoBehaviour
// {
//     public int damageCount = 10;

//     private void OnCollisionEnter(Collision collision)
//     {
//         StartCoroutine(FindObjectOfType<PlayerManager>().Damage(damageCount));
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damageCount = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            StartCoroutine(FindObjectOfType<PlayerManager>().Damage(damageCount));
        }
    }
}