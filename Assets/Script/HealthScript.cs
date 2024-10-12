// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class HealthPickupScript : MonoBehaviour
// {
//     public int healthAmount = 20; 
//     private bool canHeal = true; 
//     private const int maxHealth = 100; 

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Player")) 
//         {
//             if (canHeal) 
//             {
//                 StartCoroutine(HealPlayer());
//             }
//         }
//     }

//     private IEnumerator HealPlayer()
//     {
//         canHeal = false;

//         PlayerManager.playerHP = Mathf.Min(PlayerManager.playerHP + healthAmount, maxHealth);
//         Debug.Log("Health restored: " + healthAmount + ", Current Player HP: " + PlayerManager.playerHP);

//         yield return new WaitForSeconds(10f); 
//         canHeal = true; 
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickupScript : MonoBehaviour
{
    public int healthAmount = 20; 
    private bool canHeal = true; 
    private const int maxHealth = 100; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (canHeal) 
            {
                StartCoroutine(HealPlayer(other.GetComponent<PlayerManager>())); 
            }
        }
    }

    private IEnumerator HealPlayer(PlayerManager player)
    {
        canHeal = false;

        player.bloodOverlay.SetActive(false);

        PlayerManager.playerHP = Mathf.Min(PlayerManager.playerHP + healthAmount, maxHealth);
        Debug.Log("Health restored: " + healthAmount + ", Current Player HP: " + PlayerManager.playerHP);

        yield return new WaitForSeconds(10f); 
        canHeal = true; 
    }
}