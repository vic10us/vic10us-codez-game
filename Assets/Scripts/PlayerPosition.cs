using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("Obstacle", System.StringComparison.OrdinalIgnoreCase))
        {
            movement.enabled = false;
            Debug.Log($"Collided with {collision.collider.name}");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
