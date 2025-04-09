using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Bowl01_Win_Ingredients : MonoBehaviour
{
    // Tags that will cause a lose condition if they touch the bowl
    private HashSet<string> loseTags = new HashSet<string>
    {
        "Flour",
        "BakingPowder",
        "Water",
        "Oil",
        "Salt"
    };

    void OnTriggerEnter2D(Collider2D other)
    {
        if (loseTags.Contains(other.tag))
        {
            Debug.Log("Correct ingredient entered: " + other.name);
            SceneManager.LoadScene("WinPage");
        }
    }
}