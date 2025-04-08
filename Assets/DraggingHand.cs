using UnityEngine;

public class DraggingHand : MonoBehaviour
{
     public GameObject GameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("herer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
         if(col.gameObject.name == "MeasureCUP"){
         if (GameManager != null){
            if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==false){
                GameManager.GetComponent<GameManager_script>().Cupbeingdragged =true;
             }

         }
    }
    if(col.gameObject.name == "Flour"){
         if (GameManager != null){
            Debug.Log("flour");
            if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==true){
           
                //drag the flour :)
               if(GameManager.GetComponent<GameManager_script>().flourPickedUp ==false){
                GameManager.GetComponent<GameManager_script>().flourPickedUp =true;
               }

             }

         }
    }
 }
  void OnTriggerExit2D(Collider2D col){
     if(col.gameObject.name == "MeasureCUP"){
        Debug.Log("OFF");
         if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==true){
                GameManager.GetComponent<GameManager_script>().Cupbeingdragged =false;
             }

         //drop the flour if it was picked up:)
        if(GameManager.GetComponent<GameManager_script>().flourPickedUp ==true){
            GameManager.GetComponent<GameManager_script>().flourPickedUp =false;
        }
     }
  }
}
