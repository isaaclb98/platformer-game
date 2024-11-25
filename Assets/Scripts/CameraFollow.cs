using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; 
    public Vector3 offset;  
    public float smoothSpeed;
    public float verticalFollowSpeed = 2f;

    void LateUpdate()
    {
        if (player)
        {
            float targetY = Mathf.Lerp(transform.position.y, player.position.y + offset.y, Time.deltaTime * verticalFollowSpeed);

            Vector3 targetPosition = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);

            // Smoothly interpolate between the camera's current position and the target position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);

            transform.position = smoothedPosition;
        }

    }
}
