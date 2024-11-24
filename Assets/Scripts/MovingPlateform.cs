using UnityEngine;

public class HorizntalPlatform: MonoBehaviour
{
    public float moveSpeed = 2f;       // Speed of movement
    public float moveDistance = 5f;   // Distance to move from the starting point

    private Vector3 startPosition;
    private bool movingRight = true;

    void Start()
    {
        // Record the starting position of the platform
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the platform's new position
        if (movingRight)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;

            // Reverse direction if the platform exceeds the right limit
            if (transform.position.x >= startPosition.x + moveDistance)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;

            // Reverse direction if the platform exceeds the left limit
            if (transform.position.x <= startPosition.x - moveDistance)
            {
                movingRight = true;
            }
        }
    }
}