using UnityEngine;

public class Salt_label : MonoBehaviour
{
    public GameObject labelObject; 

    void Start()
    {
        if (labelObject != null)
            labelObject.SetActive(false); 
    }

    void OnMouseEnter()
    {
        if (labelObject != null)
            labelObject.SetActive(true); 
    }
    void OnMouseExit()
    {
        if (labelObject != null)
            labelObject.SetActive(false); 
    }
}
