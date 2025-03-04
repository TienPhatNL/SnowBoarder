using UnityEngine;

public class HighscoreMenu : MonoBehaviour
{
    public GameObject highScoreOverlay; 

    public void ShowScoresOverlay()
    {
        if (highScoreOverlay != null)
        {
            highScoreOverlay.SetActive(true); 
        }
        else
        {
            Debug.LogWarning("HighScore Overlay is not assigned in the LevelsMenu script.");
        }
    }

    // Called when the Back button is clicked
    public void HideScoresOverlay()
    {
        if (highScoreOverlay != null)
        {
            highScoreOverlay.SetActive(false); // Hide the 
        }
    }
}