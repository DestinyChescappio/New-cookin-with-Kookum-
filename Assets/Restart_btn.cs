using UnityEngine;

public class Restart_btn : MonoBehaviour
{
    public GameObject arrow_01; 

    void Start()
    {
        if (arrow_01 != null)
            arrow_01.SetActive(false); // Hide play_01 on start
    }

    void OnMouseEnter()
    {
        if (arrow_01 != null)
            arrow_01.SetActive(true);  

        gameObject.SetActive(false);  
    }
}