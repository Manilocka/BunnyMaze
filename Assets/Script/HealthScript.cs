
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthScript : MonoBehaviour
{
    public int healthAmount = 20; 
    private bool canHeal = true; 
    private const int maxHealth = 100; 
    
    public GameObject cat; 
    public TextMeshProUGUI messageText; 
    public GameObject bloodOverlay; 

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("AttackCollider")) 
        {
            Die();
        } 
        else if (other.CompareTag("Player")) 
        {
            if (canHeal) 
            {
                StartCoroutine(HealPlayer());
                HideBloodOverlay(); 
            }
        }
    }

    private void Die()
    {
        ShowMessage("ВЫ УБИЛИ КОТЁНКA!!!!");
        Destroy(cat); 
    }

    private IEnumerator HealPlayer()
    {
        canHeal = false; 
        PlayerManager.playerHP = Mathf.Min(PlayerManager.playerHP + healthAmount, maxHealth);
        Debug.Log("Health restored: " + healthAmount + ", Current Player HP: " + PlayerManager.playerHP);
        yield return new WaitForSeconds(10f); 
        canHeal = true; 
    }

    private void ShowMessage(string message) 
    {
        messageText.text = message; 
        messageText.gameObject.SetActive(true); 
    }

    private void HideBloodOverlay()
    {
        if (bloodOverlay != null) 
        {
            bloodOverlay.SetActive(false); 
        }
    }
}