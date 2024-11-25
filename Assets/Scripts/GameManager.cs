using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0; // Coin score
    public int keys = 0;  // Key inventory
    public TextMeshProUGUI scoreText; // UI Text for score
    public TextMeshProUGUI keyText;   // UI Text for keys

    public Button RestartButton;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    public void AddKeys(int value)
    {
        keys += value;
        UpdateKeyUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    private void UpdateKeyUI()
    {
        if (keyText != null)
        {
            keyText.text = "Keys: " + keys.ToString();
        }
    }

    public void RestartGame()
    {
    Time.timeScale = 1; 
    int nextSceneIndex = SceneManager.GetActiveScene().buildIndex;
    if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
    {
        SceneManager.LoadScene(nextSceneIndex);  
    }
    else
    {
        Debug.Log("No more levels available.");
    }
        
    }
}
