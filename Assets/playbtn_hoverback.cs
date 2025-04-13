using UnityEngine;

public class playbtn_hoverback : MonoBehaviour
{
    public GameObject play; // Drag the play GameObject here in the Inspector

    void OnMouseExit()
    {
        if (play != null)
            play.SetActive(true);

        gameObject.SetActive(false); // Hide play_01
    }
}