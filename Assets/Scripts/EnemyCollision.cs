using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Handle player death
            Debug.Log("Player Died!");
            Destroy(collision.gameObject); // Replace with your death logic
        }
    }
}
