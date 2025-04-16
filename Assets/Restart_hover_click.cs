using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_hover_click : MonoBehaviour
{
    public GameObject arrow; // public in inspector 

    void OnMouseDown()
    {
        Debug.Log("Hovered arrow_01 clicked!");
        SceneManager.LoadScene("Title"); // goes to title to "restart"
    }

    void OnMouseExit()
    {
        
        if (arrow != null)
            arrow.SetActive(true);

        gameObject.SetActive(false); // Hide arrow_01
    }
}