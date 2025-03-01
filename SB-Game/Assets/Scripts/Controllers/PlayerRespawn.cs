using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Vector3 deathOffset = new Vector3(0, 5, 0);
    private Vector3 respawnPosition;

    // Handle respawn when the event is triggered
    public void TriggerRespawn()
    {
        Respawn(); // Use the pre-set respawnPosition
    }

    // Set the death position externally
    public void SetDeathPosition(Vector3 deathPosition)
    {
        respawnPosition = deathPosition + deathOffset;
        respawnPosition.z = 0; // Ensure the Z position is always 0
    }

    private void Respawn()
    {
        // Move the player to the respawn position
        transform.position = respawnPosition;

        // Reset the player's rotation to zero (no rotation)
        transform.rotation = Quaternion.identity;

        // Enable falling by resetting gravity and velocity
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = Vector2.zero; // Reset velocity
            rb.bodyType = RigidbodyType2D.Dynamic; // Ensure gravity is active
        }

        Debug.Log("Player respawned at: " + transform.position);
    }
}
