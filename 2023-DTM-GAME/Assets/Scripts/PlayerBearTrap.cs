using UnityEngine;

public class PlayerBearTrap : MonoBehaviour
{
    private Animator animator;
    public int damageAmount = 20;

    bool isClosed = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isClosed && other.CompareTag("Player"))
        {
            CaptureEntity(other.gameObject);
        }
    }

    void CaptureEntity(GameObject entity)
    {
        isClosed = true;
        animator.SetTrigger("Close");

        PlayerHealth healthComponent = entity.GetComponent<PlayerHealth>();
        if (healthComponent != null)
        {
            healthComponent.TakeDamage(damageAmount);
        }
    }
}
