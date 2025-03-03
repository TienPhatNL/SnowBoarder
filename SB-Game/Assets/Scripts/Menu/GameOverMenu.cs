using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverOverlay : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel; // Assign in Inspector
    [SerializeField] private Button replayButton;
    [SerializeField] private Button mainMenuButton;

    private void Start()
    {
        // Ensure the overlay is hidden at the start
        gameOverPanel.SetActive(false);

        // Attach button listeners
        replayButton.onClick.AddListener(ReplayGame);
        mainMenuButton.onClick.AddListener(ReturnToMainMenu);
    }

    // Show the Game Over Screen
    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
    }

    // Reload the current scene (Restart Game)
    private void ReplayGame()
    {        

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Load the Main Menu scene
    private void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Ensure MainMenu scene is added to Build Settings
    }
}
