using UnityEngine;
using UnityEngine.SceneManagement;

public class playbtn_script : MonoBehaviour
{
    public GameObject play_01; // Drag the play_01 GameObject here in the Inspector

    void Start()
    {
        if (play_01 != null)
            play_01.SetActive(false); // Hide play_01 on start
    }

    void OnMouseEnter()
    {
        if (play_01 != null)
            play_01.SetActive(true);

        gameObject.SetActive(false); // Hide this (play)
    }

    void OnMouseDown()
    {
        Debug.Log("Play button clicked!");
        SceneManager.LoadScene("StartScene");
    }
}
