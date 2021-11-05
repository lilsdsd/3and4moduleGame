using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
   
   public List<GameObject> Alarms;
   
    
   


    void Start()
    {
        for(int i =0; i < Alarms.Count; i++ ){
            Alarms[i].SetActive(true);
        }
       // Alarms.
    }

    public void OpenMessageApp(){
        SceneManager.LoadScene("Lv1Message");
        PopUpMemoScript.isFirstChecked = true;
    }

       public void OpenBankApp(){
        SceneManager.LoadScene("Lv1BankApp");
    }

    public void OpenBirdBookApp(){
        SceneManager.LoadScene("Lv1BirdBooks");
    }

    public void OpenSettingApp(){
        SceneManager.LoadScene("SettingApp");
    }

    public void OpenMemoApp(){
        SceneManager.LoadScene("Lv1MemoApp");
    }

    public void OpenSNSApp(){
        SceneManager.LoadScene("Lv1SNS");
    }
    public void OpenBookBori(){
        SceneManager.LoadScene("Lv1BookBori");
    }


}
 
     