using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("How fast the object moves.")]
    public float speed = 2.0f;

    [Tooltip("How far the object moves from its starting position.")]
    public float distance = 3.0f;

    [Tooltip("The direction of movement (e.g., set X=1 for horizontal).")]
    public Vector3 direction = new Vector3(1, 0, 0);

    private Vector3 startPosition;

    void Start()
    {
        // Remember where the object started so movement is relative to this point
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position
        // Mathf.Sin creates a wave between -1 and 1
        // Time.time * speed controls how fast the wave cycles
        float offset = Mathf.Sin(Time.time * speed) * distance;

        // Apply the offset to the starting position
        transform.position = startPosition + (direction.normalized * offset);
    }
}