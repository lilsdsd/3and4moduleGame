using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeathBar : MonoBehaviour
{
    public Image HealthBar;
    public float CurrentHealth;
    public GameObject VideoContentor;

    private float MaxHealth = 100f;

    private bool isPlaying = false;

    private void Start(){
        HealthBar = GetComponent<Image>();
        CurrentHealth = 0f;

    }

    private void Update() {
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
        Debug.Log(Mathf.RoundToInt(CurrentHealth));
        if (isPlaying == true){

            switch(Mathf.RoundToInt(CurrentHealth)){
                case 0:// 1
                    StartCoroutine( VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect());
                    CurrentHealth += 1;
                break; 
                case 6:  // 2
             //  VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect();
              StartCoroutine( VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect());
                CurrentHealth += 1;
                break;

                case 11:  //3
              //  VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect();
               StartCoroutine( VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect());
               CurrentHealth += 1;
                break;

                case 16:  //4
               // VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect();
                StartCoroutine( VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect());
                CurrentHealth += 1;
                break;

                case 21:  //5
               // VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect();
                StartCoroutine( VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect());
                CurrentHealth += 1;
                break;

                case 26: // ChangeToNextContect() event going to trigger event
               // VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect();
                StartCoroutine( VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect());
                CurrentHealth += 1;
                break;
                case 35:
                StartCoroutine( VideoContentor.GetComponent<Lv1VideoContentScript>().ChangeToNextContect());
                    isPlaying = false;
                break;

                default: 
                break;  
                
            }

            CurrentHealth += 1*Time.deltaTime;
        }
        
    }

    public void Play(){
        isPlaying = true;
    }

    

}
