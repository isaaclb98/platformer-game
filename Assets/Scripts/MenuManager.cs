using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject menuCanvas; // Reference to the Menu Canvas

    // Toggle menu visibility
    public void ToggleMenu()
    {
        bool isMenuActive = menuCanvas.activeSelf;
        menuCanvas.SetActive(!isMenuActive);

        // Pause or resume the game
        if (menuCanvas.activeSelf)
        {
            Time.timeScale = 0; // Pause the game
        }
        else
        {
            Time.timeScale = 1; // Resume the game
        }
    }

    // Restart the current level
    public void RestartLevel()
    {
        Time.timeScale = 1; // Ensure the game isn't paused
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Resume the game
    public void ResumeGame()
    {
        menuCanvas.SetActive(false); // Hide the menu
        Time.timeScale = 1; // Resume the game
    }
}

