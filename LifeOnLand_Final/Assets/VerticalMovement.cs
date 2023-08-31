using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float speed = 4f; // The speed of the vertical movement
    public float distance = 4f; // The distance of the vertical movement

    private float startingY; // The starting Y position of the asset
    private float direction = 1f; // The direction of the vertical movement (+1 or -1)

    void Start()
    {
        startingY = transform.position.y; // Record the starting Y position of the asset
    }

    void Update()
    {
        // Calculate the new Y position based on the current direction and speed
        float newY = transform.position.y + (direction * speed * Time.deltaTime);

        // Check if the asset has moved past the maximum distance
        if (Mathf.Abs(newY - startingY) > distance)
        {
            // If so, reverse the direction of movement
            direction *= -1f;
        }

        // Set the new Y position of the asset
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
