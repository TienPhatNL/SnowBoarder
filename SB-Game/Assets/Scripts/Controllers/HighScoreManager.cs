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
    public GameObject highScoreOverlay;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        highScoreText1 = GameObject.Find("Lv1Txt").GetComponent<TextMeshProUGUI>();
        highScoreText2 = GameObject.Find("Lv2Txt").GetComponent<TextMeshProUGUI>();
        highScoreText3 = GameObject.Find("Lv3Txt").GetComponent<TextMeshProUGUI>();

        highScoreOverlay.SetActive(false);
        DontDestroyOnLoad(instance);
    }

    private void Start()
    {

    }

    public void UpdateHighScore1(int score)
    {
        if (score > highScore1)
        {
            highScore1 = score;
            highScoreText1.text = $"Lv 1: {highScore1}";
        }
    }

    public void UpdateHighScore2(int score)
    {
        if (score > highScore2)
        {
            highScore1 = score;
            highScoreText2.text = $"Lv 2: {highScore2}";
        }
    }

    public void UpdateHighScore3(int score)
    {
        if (score > highScore3)
        {
            highScore1 = score;
            highScoreText3.text = $"Lv 3: {highScore3}";
        }
    }
}
