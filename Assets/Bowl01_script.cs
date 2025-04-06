using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl01_script : MonoBehaviour
{
    // Called when a collider enters the trigger zone of the Bowl
    void OnTriggerEnter(Collider other)
    {
        // Check if the object that collided with the Bowl has the tags Flour, Oil, or Baking Powder
        if (other.CompareTag("Flour") || other.CompareTag("Oil") || other.CompareTag("Baking Powder")) 
        {
            // Stop the object from moving by setting its Rigidbody's velocity to zero
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero; // Stops the object from moving
                rb.angularVelocity = Vector3.zero; // Stops the object from rotating
                rb.isKinematic = true; // Make the object static (no more physics forces applied)
            }
        }
    }

    // Optionally, use OnCollisionEnter for non-trigger colliders
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flour") || collision.gameObject.CompareTag("Oil") || collision.gameObject.CompareTag("Baking Powder")) 
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero; // Stops the object from moving
                rb.angularVelocity = Vector3.zero; // Stops the object from rotating
                rb.isKinematic = true; // Make the object static (no more physics forces applied)
            }
        }
    }
}

