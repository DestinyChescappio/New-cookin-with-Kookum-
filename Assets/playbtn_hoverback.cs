using UnityEngine;
using UnityEngine.SceneManagement;

public class playbtn_hover_click : MonoBehaviour
{
    public GameObject play; 

    void OnMouseDown()
    {
        Debug.Log("Hovered Play_01 clicked!");
        SceneManager.LoadScene("StartScene");
    }

    void OnMouseExit()
    {
        
        if (play != null)
            play.SetActive(true);

        gameObject.SetActive(false); // Hide play_01
    }
}

//highlighted button script 
//public "Play" has the plain object in inspector + highlighted button is disabled 