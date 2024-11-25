using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0; // Coin score
    public int keys = 0;  // Key inventory
    public TextMeshProUGUI scoreText; // UI Text for score
    public TextMeshProUGUI keyText;   // UI Text for keys

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
}
