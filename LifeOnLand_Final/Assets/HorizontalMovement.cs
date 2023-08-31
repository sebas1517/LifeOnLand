using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    public float speed = 2f; // The speed of the horizontal movement
    public float distance = 1f; // The distance of the horizontal movement

    private float startingZ; // The starting X position of the asset
    private float direction = 1f; // The direction of the horizontal movement (+1 or -1)

    void Start()
    {
        startingZ = transform.position.z; // Record the starting X position of the asset
    }

    void Update()
    {
        // Calculate the new X position based on the current direction and speed
        float newZ = transform.position.z + (direction * speed * Time.deltaTime);

        // Check if the asset has moved past the maximum distance
        if (Mathf.Abs(newZ - startingZ) > distance)
        {
            // If so, reverse the direction of movement
            direction *= -1f;
        }

        // Set the new X position of the asset
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
    }
}
