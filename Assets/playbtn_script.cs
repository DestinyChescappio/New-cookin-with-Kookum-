using UnityEngine;

public class playbtn_script : MonoBehaviour
{
    public GameObject play_01; 

    void Start()
    {
        if (play_01 != null)
            play_01.SetActive(false); // Hide play_01 on start
    }

    void OnMouseEnter()
    {
        if (play_01 != null)
            play_01.SetActive(true);  

        gameObject.SetActive(false);  
    }
}

//plain button script 
//public "Play" has the highlighted object in inspector 