using UnityEngine;

public class Flour_label : MonoBehaviour
{
    public GameObject labelObject; // 

    void Start()
    {
        if (labelObject != null)
            labelObject.SetActive(false); 
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
