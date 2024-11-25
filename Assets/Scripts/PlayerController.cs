using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    private Rigidbody2D _rb;
    private bool _isGrounded;
    
    public Transform respawnPoint;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(move * moveSpeed, _rb.velocity.y);

        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("DeathZone"))
        {
            Die();
        }
        
        if (collision.contacts[0].normal.y > 0.5f)
        {
            _isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
    }
    
    private void Die()
    {
        // Set to UI later
        Debug.Log("Player died!");
        transform.position = respawnPoint != null ? respawnPoint.position : new Vector3(0, 0, 0);
    }
}
