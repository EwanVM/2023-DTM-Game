using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            DefeatEnemy();

        }
    }

    void DefeatEnemy()
    {
        Destroy(gameObject); // Destroy the enemy GameObject
    }
}
