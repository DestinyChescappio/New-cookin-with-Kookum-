using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureCUP_script : MonoBehaviour
{
    private bool isFollowing = false;
    public GameObject gamemanager;

    void Start()
    {

    }
    void Update()
    {
        if (isFollowing)
        {
            FollowMouse();
        }
    }

    void OnMouseDown()
    {
        isFollowing = !isFollowing;

        gamemanager.GetComponent<GameManager_script>().Cupbeingdragged = isFollowing;
//debugging 
        Debug.Log(gamemanager.GetComponent<GameManager_script>().Cupbeingdragged);
    }

    void FollowMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.WorldToScreenPoint(transform.position).z; // Maintain depth
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition); // Convert screen position to world position
    }


}

