// using UnityEngine;

// public class Enemy : MonoBehaviour
// {
//     public int maxHealth = 200; 
//     private int currentHealth;

//     void Start()
//     {
//         currentHealth = maxHealth;
//     }

//     void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("AttackCollider"))
//         {
//             TakeDamage(10); 
//         }
//     }

//     void TakeDamage(int damage)
//     {
//         currentHealth -= damage;

//         if (currentHealth <= 0)
//         {
//             Die();
//         }
//     }

//     void Die()
//     {
//         Destroy(gameObject); 
//     }
// }

using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 200; 
    private int currentHealth;

    public GameObject[] beeImages; 

    public int enemyIndex;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AttackCollider"))
        {
            TakeDamage(10); 
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (enemyIndex >= 0 && enemyIndex < beeImages.Length)
        {
            beeImages[enemyIndex].SetActive(true);
        }

        Destroy(gameObject); 
    }
}