using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int score = 0;
    private TextMeshProUGUI scoreText; // Kéo Text từ Canvas vào đây trong Inspector

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
