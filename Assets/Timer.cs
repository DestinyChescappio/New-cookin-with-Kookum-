using UnityEngine;
using TMPro; 

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime = 60f; //can set this default is inspector
    

    // Update is called once per frame
    void Update()
    {
        // more than 0
        if (remainingTime > 0) 
        {
            remainingTime -= Time.deltaTime;
        }
        // les than 0
        if (remainingTime <= 0) 
        {
            remainingTime = 0;
            // INSERT LOSING SCENE
        }
        
        //minutes and seconds
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); 
    }
}
