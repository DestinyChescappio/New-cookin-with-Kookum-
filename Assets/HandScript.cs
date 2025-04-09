using UnityEngine;

public class Hand_script : MonoBehaviour
{
    public GameObject HandOPEN;   
    public GameObject HandCLOSED; 

      public GameObject GameManager;

    void Start()
    {
        if (HandOPEN != null) HandOPEN.SetActive(true); // HandOPEN shows up
        if (HandCLOSED != null) HandCLOSED.SetActive(false); // HandCLOSED hides
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // Whenbutton is pressed
        {
            if (HandOPEN != null) HandOPEN.SetActive(false);   // hide HandOPEN
            if (HandCLOSED != null)
            {
                HandCLOSED.SetActive(true); // show HandCLOSED
                FollowMouse(HandCLOSED);   // Moveing HandCLOSED
            }
        }
        else // When mouse button is released, HandOPEN or HndCLSOED 
        {
            if (HandOPEN != null)
            {
                HandOPEN.SetActive(true);  
                FollowMouse(HandOPEN);     
            }
            if (HandCLOSED != null) HandCLOSED.SetActive(false); 
        }
    }

    void FollowMouse(GameObject hand)
    {
       
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f; 
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
        if (hand != null) hand.transform.position = worldPosition;
    }

    


}