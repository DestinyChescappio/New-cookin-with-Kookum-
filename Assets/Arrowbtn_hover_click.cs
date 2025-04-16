using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrowbtn_hover_click : MonoBehaviour
{
    public GameObject arrow; // public in inspector 

    void OnMouseDown()
    {
        Debug.Log("Hovered arrow_01 clicked!");
        SceneManager.LoadScene("SampleScene");
    }

    void OnMouseExit()
    {
        
        if (arrow != null)
            arrow.SetActive(true);

        gameObject.SetActive(false); // Hide arrow_01
    }
}