using UnityEngine;
using UnityEngine.SceneManagement; 

public class Enemy : MonoBehaviour
{
    public int maxHealth = 200; 
    private int currentHealth;

    public GameObject[] beeImages; 
    public int enemyIndex;

    public GameObject Points; 

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

        if (AllBeeImagesActivated())
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);
        }

        Destroy(gameObject); 
    }

    bool AllBeeImagesActivated()
    {
        foreach (GameObject beeImage in beeImages)
        {
            if (!beeImage.activeSelf)
            {
                return false;
            }
        }
        return true; 
    }
}


