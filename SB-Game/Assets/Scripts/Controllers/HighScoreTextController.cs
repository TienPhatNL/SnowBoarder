using TMPro;
using UnityEngine;

public class HighScoreTextController : MonoBehaviour
{
    private TextMeshProUGUI highScoreText1;
    private TextMeshProUGUI highScoreText2;
    private TextMeshProUGUI highScoreText3;

    private void Awake()
    {
        highScoreText1 = GameObject.Find("Lv1Txt").GetComponent<TextMeshProUGUI>();
        highScoreText2 = GameObject.Find("Lv2Txt").GetComponent<TextMeshProUGUI>();
        highScoreText3 = GameObject.Find("Lv3Txt").GetComponent<TextMeshProUGUI>();
        if (GameObject.Find("Lv1Txt") == null)
        {
            Debug.Log("null");
        }
        else Debug.Log("not null");

        if (highScoreText1 == null)
        {
            Debug.Log("null2");
        }
        else Debug.Log("not null2");

        if (HighScoreManager.instance == null) Debug.Log("null3");    
        else Debug.Log("not null3");

        highScoreText1.text = $"Lv 1: {HighScoreManager.instance.highScore1}";
        highScoreText2.text = $"Lv 2: {HighScoreManager.instance.highScore2}";
        highScoreText3.text = $"Lv 3: {HighScoreManager.instance.highScore3}";
    }

}
