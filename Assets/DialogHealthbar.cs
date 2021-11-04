using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogHealthbar : MonoBehaviour
{
     public Image HealthBar;
     public GameObject GameEventControler;
     public GameObject Text;
    public float CurrentHealth;
    private float MaxHealth = 90f;
    public bool isCounting ;

    private void Start(){
        HealthBar = GetComponent<Image>();
        CurrentHealth = 0f;
        Text.SetActive(false);
    }
       public void FixedUpdate() {
           HealthBar.fillAmount = CurrentHealth / MaxHealth;
           if (isCounting == true && CurrentHealth <= 90 ){
            
           CurrentHealth += 30*Time.deltaTime;
           }else if (isCounting != false){
               CurrentHealth = 0;
                  Text.SetActive(false);
           }
           if(CurrentHealth >= 88){
               Text.SetActive(true);
           }
        
       }


}
