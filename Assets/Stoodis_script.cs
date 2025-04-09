using UnityEngine;
using UnityEngine.SceneManagement;

public class Stoodis_script : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("arrow button clicked!");
        SceneManager.LoadScene("SampleScene");
    }
}
