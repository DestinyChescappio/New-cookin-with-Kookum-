using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bakingsoda_script : MonoBehaviour
{
    public GameObject GameManager;
    private bool isDragging = false;
    private Vector3 offset;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (isDragging == false)
        {
            if (GameManager != null && GameManager.GetComponent<GameManager_script>().bakingsodaPickup == true)
            {
                Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = transform.position.z;
                offset = transform.position - mousePos;
                isDragging = true;
            }
        }

        if (isDragging)
        {
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = transform.position.z;
            transform.position = mousePosition + offset;

            if (GameManager != null && GameManager.GetComponent<GameManager_script>().bakingsodaPickup == false)
            {
                isDragging = false;
            }
        }
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = Mathf.Abs(mainCamera.transform.position.z - transform.position.z);
        return mainCamera.ScreenToWorldPoint(mousePoint);
    }
}
