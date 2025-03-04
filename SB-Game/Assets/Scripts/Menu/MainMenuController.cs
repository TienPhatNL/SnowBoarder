using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public GameObject optionsOverlay; // Reference to the Options Overlay panel
    public GameObject levelsOverlay;
    public GameObject highScoreOverlay;

    // Called when the "Play" button is clicked
    public void OnPlayButtonClicked()
    {
        // Show the levels overlay
        if (levelsOverlay != null)
        {
            levelsOverlay.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Levels Overlay is not assigned in the MainMenuController.");
        }
    }

    // Called when the "Options" button is clicked
    public void OnOptionsButtonClicked()
    {
        // Show the options overlay
        if (optionsOverlay != null)
        {
            optionsOverlay.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Options Overlay is not assigned in the MainMenuController.");
        }
    }

    public void OnHighScoreButtonClicked()
    {
        // Show the options overlay
        if (highScoreOverlay != null)
        {
            highScoreOverlay.SetActive(true);
        }
        else
        {
            Debug.LogWarning("highScoreOverlay is not assigned in the MainMenuController.");
        }
    }

    // Called when the "Quit" button is clicked
    public void OnQuitButtonClicked()
    {
        // Quit the application (works in builds, not in the editor)
        Application.Quit();

        // For testing in the editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}