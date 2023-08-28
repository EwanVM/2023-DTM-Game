using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public GameObject deathScreenUI;

    void Start()
    {
        currentHealth = maxHealth;
        deathScreenUI.SetActive(false);
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            deathScreenUI.SetActive(true);
        }
    }
}
