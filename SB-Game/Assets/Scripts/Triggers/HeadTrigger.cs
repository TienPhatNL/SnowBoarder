using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HeadTrigger : MonoBehaviour
{
    public BoolVariable IsAlive;

    public IntVariable Lives;

    [Tooltip("Event invoked when collision occurs.")]
    public UnityEvent HeadCollisionEvent;

    [Tooltip("GameObjects to interact with.")]
    public GameObject[] TriggerCandidates;

    public UnityEvent DeadCollisionEvent;

    private HashSet<GameObject> triggerCandidates;

    private void Awake()
    {
        this.triggerCandidates = new HashSet<GameObject>(this.TriggerCandidates);
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

    }
}
