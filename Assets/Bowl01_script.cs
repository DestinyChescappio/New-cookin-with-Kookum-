using System.Collections.Generic;
using UnityEngine;

public class Bowl01_script : MonoBehaviour
{
    [SerializeField] private Transform snapPoint; // Optional custom snap location inside the bowl

    private HashSet<string> ingredientTags = new HashSet<string>
    {
        "Flour",
        "Oil",
        "Geletin",
        "Cornstarch",
        "Water",
        "BakingPowder",
        "BakingSoda",
        "sugarr",
        "Salt"
    };

    void OnTriggerEnter2D(Collider2D other)
    {
        if (ingredientTags.Contains(other.tag))
        {
            StopAndSnap(other.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (ingredientTags.Contains(collision.gameObject.tag))
        {
            StopAndSnap(collision.gameObject);
        }
    }

    void StopAndSnap(GameObject obj)
    {
        Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = Vector2.zero;
            rb.angularVelocity = 0f;
            rb.isKinematic = true;
        }

        // Snap the object to the bowl (or to a snapPoint if set)
        if (snapPoint != null)
        {
            obj.transform.position = snapPoint.position;
        }
        else
        {
            obj.transform.position = transform.position; // Snap to bowl's position
        }
    }
}
