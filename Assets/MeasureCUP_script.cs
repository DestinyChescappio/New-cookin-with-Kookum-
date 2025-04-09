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
        if ( gamemanager.GetComponent<GameManager_script>().Cupbeingdragged==true)
        {
            FollowMouse();
        }
    }

//     void OnMouseDown()
//     {
//         //isFollowing = !isFollowing;
//         isFollowing = true;
//         Debug.Log("mouseDOwn");

//         gamemanager.GetComponent<GameManager_script>().Cupbeingdragged = isFollowing;
// //debugging 
//         Debug.Log(gamemanager.GetComponent<GameManager_script>().Cupbeingdragged);
//     }
//     void OnMouseUp(){
//         isFollowing =false;
//     }

    void FollowMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.WorldToScreenPoint(transform.position).z; // Maintain depth
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition); // Convert screen position to world position
    }
  


}