using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1; // Value of the coin (can be customized)

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Check if the player touches the coin
        {
            // Add to the player's score
            GameManager.instance.AddScore(coinValue);

            // Destroy the coin
            Destroy(gameObject);
        }
    }
}

