using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public int requiredKeys = 1; // Minimum keys needed to open the door

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Check if the player is interacting with the door
        {
            // Check if the player has enough keys
            if (GameManager.instance.keys >= requiredKeys)
            {
                // Deduct the keys and transition to the next level
                GameManager.instance.keys = 0;
                GameManager.instance.UpdateKeyUI(); // Update the key display in the UI

                // Load the next level
                int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                Debug.Log("Not enough keys to open the door!");
                // Optionally, provide visual or audio feedback
            }
        }
    }
}
