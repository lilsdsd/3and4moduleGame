using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationScript: MonoBehaviour
{
    public Transform Alarm;
    //public float TimetoDisable; 
    // Start is called before the first frame update
    public static bool isDisabled; 
    
    void start(){
        if (isDisabled == true){
            gameObject.SetActive(false);
        }
    }
    public void OnEnable()
    {
        //Transform OringinalPos = Alarm;
        if (isDisabled == false){
            Alarm.localPosition = new Vector2 (0, -Screen.height*5);
            Alarm.LeanMoveLocalY(0,1.5f).setEaseOutExpo().delay = 1f;
        }else if (isDisabled == true){
            gameObject.SetActive(false);
        }

        
     
       
    }

    // Update is called once per frame
    public void CloseDialog()
    {   
        isDisabled = true;
         Alarm.LeanMoveLocalY(Screen.height*5,3.5f).setEaseOutExpo().delay = 0.1f;
    }
}
