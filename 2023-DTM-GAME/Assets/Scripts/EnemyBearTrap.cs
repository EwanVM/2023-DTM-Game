using UnityEngine;

public class EnemyBearTrap : MonoBehaviour
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
        if (!isClosed && other.CompareTag("Enemy"))
        {
            CaptureEntity(other.gameObject);
        }
    }

    void CaptureEntity(GameObject entity)
    {
        isClosed = true;
        animator.SetTrigger("Close");

        EnemyHealth healthComponent = entity.GetComponent<EnemyHealth>();
        if (healthComponent != null)
        {
            healthComponent.TakeDamage(damageAmount);
        }

        // You might also want to disable movement or other actions on the captured entity
    }
}
