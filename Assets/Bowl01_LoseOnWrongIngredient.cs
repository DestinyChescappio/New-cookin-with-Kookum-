using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Bowl01_LoseOnWrongIngredient : MonoBehaviour
{
    // Tags that will cause a lose condition if they touch the bowl
    private HashSet<string> loseTags = new HashSet<string>
    {
        "Cornstarch",
        "BakingSoda",
        "Geletin",
        "sugarr",
        "Sprinkles"
    };

    void OnTriggerEnter2D(Collider2D other)
    {
        if (loseTags.Contains(other.tag))
        {
            Debug.Log("Wrong ingredient entered: " + other.name);
            SceneManager.LoadScene("LosePage");
        }
    }
}