using UnityEngine;
using UnityEngine.SceneManagement;

public class playbtn_script : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Play button clicked!");
        SceneManager.LoadScene("StartScene");
    }
}
