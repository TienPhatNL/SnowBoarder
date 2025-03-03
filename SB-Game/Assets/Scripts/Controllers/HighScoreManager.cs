using TMPro;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    public static HighScoreManager instance;
    private int highScore1 = 0;
    private int highScore2 = 0;
    private int highScore3 = 0;
    private TextMeshProUGUI highScoreText1;
    private TextMeshProUGUI highScoreText2;
    private TextMeshProUGUI highScoreText3;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        highScoreText1 = GameObject.Find("HighScore1").GetComponent<TextMeshProUGUI>();
        highScoreText2 = GameObject.Find("HighScore2").GetComponent<TextMeshProUGUI>();
        highScoreText3 = GameObject.Find("HighScore3").GetComponent<TextMeshProUGUI>();

        DontDestroyOnLoad(instance);
    }

    public void UpdateHighScore1(int score)
    {
        if (score > highScore1)
        {
            highScore1 = score;
            highScoreText1.text = $"Map 1: {highScore1}";
        }
    }

    public void UpdateHighScore2(int score)
    {
        if (score > highScore2)
        {
            highScore1 = score;
            highScoreText2.text = $"Map 2: {highScore2}";
        }
    }

    public void UpdateHighScore3(int score)
    {
        if (score > highScore3)
        {
            highScore1 = score;
            highScoreText3.text = $"Map 3: {highScore3}";
        }
    }
}
