using UnityEngine;

public class ChaserEnemy : MonoBehaviour
{
    public float speed = 3f;
    public float detectionRange = 5f;

    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player != null)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);

            // Chase player if within detection range
            if (distanceToPlayer <= detectionRange)
            {
                Vector2 direction = (player.transform.position - transform.position).normalized;
                transform.Translate(direction * speed * Time.deltaTime);
            }
        }
    }
}
