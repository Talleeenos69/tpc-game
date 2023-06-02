using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    public Rigidbody rb;
    public Transform playerObject;
    public float rollRotationSpeed = 360f; // Adjust the speed of the roll rotation

    private void Update()
    {
        // Get the parent object's velocity
        Vector3 velocity = rb.velocity;

        // Calculate the roll rotation based on the velocity
        Quaternion rollRotation = Quaternion.Euler(velocity.magnitude * rollRotationSpeed * Time.deltaTime, 0f, 0f);

        // Apply the roll rotation to the player object
        playerObject.localRotation *= rollRotation;
    }
}
