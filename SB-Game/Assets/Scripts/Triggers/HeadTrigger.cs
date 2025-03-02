using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class HeadTrigger : MonoBehaviour
{
    public BoolVariable IsAlive;
    public IntVariable Lives;

    [Tooltip("UI Text to display Lives")]
    public TextMeshProUGUI livesText;

    [Tooltip("Overlay UI to show when game over")]
    public GameOverOverlay gameOverOverlay; // Assign in Inspector

    [Tooltip("Event invoked when collision occurs.")]
    public UnityEvent HeadCollisionEvent;

    [Tooltip("GameObjects to interact with.")]
    public GameObject[] TriggerCandidates;

    public PlayerRespawn playerRespawn;

    public UnityEvent DeadCollisionEvent;

    private HashSet<GameObject> triggerCandidates;

    private void Awake()
    {
        this.triggerCandidates = new HashSet<GameObject>(this.TriggerCandidates);
    }

    private void Start()
    {
        Debug.Log("[HeadTrigger] Game started. Initial Lives: " + Lives.Value);
        UpdateLivesUI(); // UI updates after everything initializes
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("[HeadTrigger] Collision detected. Current Lives: " + Lives.Value + ", IsAlive: " + IsAlive.Value);

        if (!IsAlive.Value)
        {
            Debug.Log("[HeadTrigger] Player is already dead. Ignoring collision.");
            return;
        }

        HeadCollisionEvent.Invoke();

        // Reduce lives before checking game state
        if (Lives.Value > 0)
        {
            Vector3 deathPosition = transform.position;
            playerRespawn.SetDeathPosition(deathPosition);
            playerRespawn.TriggerRespawn();
        }

        // Check if player has lives left
        if (Lives.Value <= 0)
        {
            Debug.Log("[HeadTrigger] Player has no more lives. Game over.");
            IsAlive.Value = false;
            DeadCollisionEvent.Invoke();
            gameOverOverlay.ShowGameOver(); // Show UI
        }

        UpdateLivesUI();
    }

    private void UpdateLivesUI()
    {
        Debug.Log("[HeadTrigger] Updating UI. Lives: " + Lives.Value);

        if (livesText != null)
        {
            livesText.text = "Lives: " + Lives.Value;
        }

        if (Lives.Value <= 0 || !IsAlive.Value)
        {
            gameOverOverlay.ShowGameOver(); // Show UI
        }
    }

    
}
