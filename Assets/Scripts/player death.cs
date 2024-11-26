using UnityEngine;

public class KillPlayerOnContact : MonoBehaviour
{
    public Transform respawnPoint; // Assign a respawn point in the Inspector or via another script

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player Died!");
            Die(collision.gameObject);
        }
    }

    private void Die(GameObject player)
    {
        Debug.Log("Respawning Player...");
        
        // Move the player to the respawn point or default position (0,0,0) if no respawn point is assigned
        player.transform.position = respawnPoint != null ? respawnPoint.position : new Vector3(0, 0, 0);
    }
}
