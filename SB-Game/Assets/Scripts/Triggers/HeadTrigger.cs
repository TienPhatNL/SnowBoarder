using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class HeadTrigger : MonoBehaviour
{
    public BoolVariable IsAlive;
    public IntVariable Lives;

    [Tooltip("UI Text to display Lives")]
    public TextMeshProUGUI livesText; // Add this field

    [Tooltip("Event invoked when collision occurs.")]
    public UnityEvent HeadCollisionEvent;

    [Tooltip("GameObjects to interact with.")]
    public GameObject[] TriggerCandidates;

    public UnityEvent DeadCollisionEvent;

    private HashSet<GameObject> triggerCandidates;

    private void Awake()
    {
        this.triggerCandidates = new HashSet<GameObject>(this.TriggerCandidates);
        UpdateLivesUI(); // Update UI when game starts
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (this.triggerCandidates.Contains(other.gameObject) && this.IsAlive.Value)
        {
            this.HeadCollisionEvent.Invoke();
        }

        if (this.Lives.Value == 0)
        {
            this.DeadCollisionEvent.Invoke();
        }

        UpdateLivesUI(); // Update UI after lives change
    }

    private void UpdateLivesUI()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + Lives.Value; // Update text
        }
    }
}
