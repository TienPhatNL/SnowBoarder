using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public GameObject levelsOverlay; // Reference to the Levels Overlay panel

    // Called when the Play button is clicked
    public void ShowLevelsOverlay()
    {
        if (levelsOverlay != null)
        {
            levelsOverlay.SetActive(true); // Show the Levels Overlay
        }
        else
        {
            Debug.LogWarning("Levels Overlay is not assigned in the LevelsMenu script.");
        }
    }

    // Called when the Back button is clicked
    public void HideLevelsOverlay()
    {
        if (levelsOverlay != null)
        {
            levelsOverlay.SetActive(false); // Hide the Levels Overlay
        }
    }

    // Called when a level button is clicked
    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex); // Load the corresponding level scene
    }
}