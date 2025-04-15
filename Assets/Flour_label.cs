using UnityEngine;

public class Flour_label : MonoBehaviour
{
    public GameObject labelObject; // Drag your label GameObject into this field in the Inspector

    void Start()
    {
        if (labelObject != null)
            labelObject.SetActive(false); // Hide it initially
    }

    void OnMouseEnter()
    {
        if (labelObject != null)
            labelObject.SetActive(true); // Show when hovered
    }

    void OnMouseExit()
    {
        if (labelObject != null)
            labelObject.SetActive(false); // Hide when not hovered
    }
}
