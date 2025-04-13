using UnityEngine;
using UnityEngine.SceneManagement;

public class playbtn_hover_click : MonoBehaviour
{
    public GameObject play; // Optional: reference to swap back if needed

    void OnMouseDown()
    {
        Debug.Log("Hovered Play_01 clicked!");
        SceneManager.LoadScene("StartScene");
    }

    void OnMouseExit()
    {
        // Optional: Swap back to original play button if desired
        if (play != null)
            play.SetActive(true);

        gameObject.SetActive(false); // Hide play_01
    }
}
