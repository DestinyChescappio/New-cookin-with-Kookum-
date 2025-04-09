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

 //** ingredients
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
    if(col.gameObject.name == "Water"){
         if (GameManager != null){
            Debug.Log("water");
            if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==true){
           
                //drag the flour :)
               if(GameManager.GetComponent<GameManager_script>().waterPickedUp ==false){
                GameManager.GetComponent<GameManager_script>().waterPickedUp =true;
               }

             }

         }
    }
    if(col.gameObject.name == "Oil"){
         if (GameManager != null){
            Debug.Log("oil");
            if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==true){
           
                //drag the flour :)
               if(GameManager.GetComponent<GameManager_script>().oilPickedUp ==false){
                GameManager.GetComponent<GameManager_script>().oilPickedUp =true;
               }

             }

         }
    }
    if(col.gameObject.name == "BakingPowder"){
         if (GameManager != null){
            Debug.Log("bakingpowder");
            if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==true){
           
                //drag the flour :)
               if(GameManager.GetComponent<GameManager_script>().bakingpowderPickedUp ==false){
                GameManager.GetComponent<GameManager_script>().bakingpowderPickedUp =true;
               }

             }

         }
    }
    if(col.gameObject.name == "Salt"){
         if (GameManager != null){
            Debug.Log("salt");
            if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==true){
           
                //drag the flour :)
               if(GameManager.GetComponent<GameManager_script>().saltPickedUp ==false){
                GameManager.GetComponent<GameManager_script>().saltPickedUp =true;
               }

             }

         }
    }
    if(col.gameObject.name == "BakingSoda"){
         if (GameManager != null){
            Debug.Log("bakingSoda");
            if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==true){
           
                //drag the flour :)
               if(GameManager.GetComponent<GameManager_script>().bakingsodaPickup ==false){
                GameManager.GetComponent<GameManager_script>().bakingsodaPickup =true;
               }

             }

         }
    }
    if(col.gameObject.name == "Corn Starch"){
         if (GameManager != null){
            Debug.Log("cornstarch");
            if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==true){
           
                //drag the flour :)
               if(GameManager.GetComponent<GameManager_script>().cornstarchPickup ==false){
                GameManager.GetComponent<GameManager_script>().cornstarchPickup =true;
               }

             }

         }
    }
    if(col.gameObject.name == "geletin"){
         if (GameManager != null){
            Debug.Log("geletin");
            if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==true){
           
                //drag the flour :)
               if(GameManager.GetComponent<GameManager_script>().geletinPickup ==false){
                GameManager.GetComponent<GameManager_script>().geletinPickup =true;
               }

             }

         }
    }
    if(col.gameObject.name == "sprinkles"){
         if (GameManager != null){
            Debug.Log("sprinkles");
            if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==true){
           
                //drag the flour :)
               if(GameManager.GetComponent<GameManager_script>().sprinklesPickup ==false){
                GameManager.GetComponent<GameManager_script>().sprinklesPickup =true;
               }

             }

         }
    }
    if(col.gameObject.name == "Sugar"){
         if (GameManager != null){
            Debug.Log("sugar");
            if(GameManager.GetComponent<GameManager_script>().Cupbeingdragged ==true){
           
                //drag the flour :)
               if(GameManager.GetComponent<GameManager_script>().sugarPickup ==false){
                GameManager.GetComponent<GameManager_script>().sugarPickup =true;
               }

             }

         }
    }
 }

 
 //** ingredients
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
        // water
        if(GameManager.GetComponent<GameManager_script>().waterPickedUp ==true){
            GameManager.GetComponent<GameManager_script>().waterPickedUp =false;
        }
        if(GameManager.GetComponent<GameManager_script>().oilPickedUp ==true){
            GameManager.GetComponent<GameManager_script>().oilPickedUp =false;
        }
        if(GameManager.GetComponent<GameManager_script>().bakingpowderPickedUp ==true){
            GameManager.GetComponent<GameManager_script>().bakingpowderPickedUp =false;
        }
        if(GameManager.GetComponent<GameManager_script>().saltPickedUp ==true){
            GameManager.GetComponent<GameManager_script>().saltPickedUp =false;
        }
        if(GameManager.GetComponent<GameManager_script>().bakingsodaPickup ==true){
            GameManager.GetComponent<GameManager_script>().bakingsodaPickup =false;
        }
        if(GameManager.GetComponent<GameManager_script>().cornstarchPickup ==true){
            GameManager.GetComponent<GameManager_script>().cornstarchPickup =false;
        }
        if(GameManager.GetComponent<GameManager_script>().geletinPickup ==true){
            GameManager.GetComponent<GameManager_script>().geletinPickup =false;
        }
        if(GameManager.GetComponent<GameManager_script>().sprinklesPickup ==true){
            GameManager.GetComponent<GameManager_script>().sprinklesPickup =false;
        }
        if(GameManager.GetComponent<GameManager_script>().sugarPickup ==true){
            GameManager.GetComponent<GameManager_script>().sugarPickup =false;
        }
     }
     }

  }