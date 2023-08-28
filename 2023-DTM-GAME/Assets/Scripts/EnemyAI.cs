using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 10f;
    public float attackRange = 2f;
    public int damageAmount = 10; // Amount of damage dealt to player
    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange)
        {
            agent.SetDestination(player.position);

            if (distanceToPlayer <= attackRange)
            {
                // Attack logic here (deal damage to player)
                DealDamageToPlayer();
            }
            else
            {
                // Movement logic here
                bool isWalking = agent.velocity.magnitude > 0.1f; // Set IsWalking based on velocity
                animator.SetBool("isWalking", isWalking);
            }
        }
        else
        {
            // Idle or patrolling behavior
            animator.SetBool("isWalking", false);
        }
    }

    void DealDamageToPlayer()
    {
        // Check if the player has a health component or script
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            // Deal damage to the player
            playerHealth.TakeDamage(damageAmount);
        }
    }
}
