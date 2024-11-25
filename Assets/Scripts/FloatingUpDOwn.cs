using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    public float moveSpeed = 1f;       // Speed of movement
    public float moveDistance = 2f;   // Distance to move up and down

    private Vector3 startPosition;
    private bool movingUp = true;

    void Start()
    {
        // Record the starting position of the platform
        startPosition = transform.position;
    }

    void Update()
    {
        // Move the platform up and down
        if (movingUp)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;

            // Reverse direction when reaching the top limit
            if (transform.position.y >= startPosition.y + moveDistance)
            {
                movingUp = false;
            }
        }
        else
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;

            // Reverse direction when reaching the bottom limit
            if (transform.position.y <= startPosition.y - moveDistance)
            {
                movingUp = true;
            }
        }
    }
}
