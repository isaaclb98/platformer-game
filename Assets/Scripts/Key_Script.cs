using UnityEngine;

public class Key : MonoBehaviour
{
    public int keyValue = 1; // Number of keys to add to the player's inventory

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Check if the player collides with the key
        {
            // Add keys to the player's inventory
            GameManager.instance.AddKeys(keyValue);

            // Destroy the key
            Destroy(gameObject);
        }
    }
}