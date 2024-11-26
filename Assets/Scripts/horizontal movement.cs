using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f; // Speed of the enemy
    public float moveDistance = 5f; // Total horizontal movement range

    private Vector3 startPosition;
    private int direction = 1; // 1 for right, -1 for left

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);

        // Reverse direction when reaching the edges
        if (Mathf.Abs(transform.position.x - startPosition.x) >= moveDistance)
        {
            direction *= -1;
        }
    }
}
