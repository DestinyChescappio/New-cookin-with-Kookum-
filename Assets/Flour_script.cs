using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flour_script : MonoBehaviour
{
    public GameObject gamemanager;
    private bool isDragging = false;
    private Vector3 offset;
    private Camera mainCamera;
    private Rigidbody rb;
    private bool canFall = false; // New flag to ensure gravity is applied only when needed

    void Start()
    {
        mainCamera = Camera.main;
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component to apply physics
        rb.useGravity = false; // Ensure gravity is disabled at the start
    }

    void Update()
    {
        if (isDragging)
        {
            transform.position = GetMouseWorldPos() + offset; // Move the Flour with the mouse
        }
        // else
        // {
        //     // Only enable gravity after the Flour is released and it's not touching MeasureCUP
        //     if (canFall && !IsTouchingMeasureCUP())
        //     {
        //         rb.useGravity = true; // Enable gravity when Flour is released and not near MeasureCUP
        //     }
        // }
    }

    void OnMouseDown()
    {
        //
        if(gamemanager.GetComponent<GameManager_script>().Cupbeingdragged == true){

        
//debugging 
        Debug.Log(gamemanager.GetComponent<GameManager_script>().Cupbeingdragged);

        offset = transform.position - GetMouseWorldPos();
        isDragging = true; // Start dragging when clicked
        rb.useGravity = false; // Disable gravity while dragging
        canFall = false; // Disable falling during the drag
    }
    }

    void OnMouseUp()
    {
        isDragging = false; // Stop dragging when mouse button is released
        //CheckForDrop();
        // canFall = true; // Allow gravity to take effect after release
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = Mathf.Abs(mainCamera.transform.position.z - transform.position.z); // Maintain depth
        return mainCamera.ScreenToWorldPoint(mousePoint);
    }

    //void CheckForDrop()
    //{
    //    GameObject bowl = GameObject.Find("Bowl01");
    //    if (bowl != null)
    //    {
    //        float distance = Vector3.Distance(transform.position, bowl.transform.position);
    //        if (distance < 1.0f) // Adjust this threshold as needed
    //        {
    //            transform.position = bowl.transform.position; // Snap to bowl
    //        }
    //    }
    //}

//     bool IsTouchingMeasureCUP()
//     {
//         GameObject measureCup = GameObject.Find("MeasureCUP");
//         if (measureCup != null)
//         {
//             // Check if the Flour is close to the MeasureCUP
//             float distance = Vector3.Distance(transform.position, measureCup.transform.position);
//             return distance < 1.0f; // Adjust this threshold to how close they should be to consider touching
//         }
//         return false;
//     }
    }
