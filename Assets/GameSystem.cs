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
   
    public int WhichLevelNum;
   


    void Start()
    {
        for(int i =0; i < Alarms.Count; i++ ){
            Alarms[i].SetActive(true);
        }
       // Alarms.
    }



    public void OpenMessageApp(){
        if (WhichLevelNum == 1){
        SceneManager.LoadScene("Lv1Message");
        PopUpMemoScript.isFirstChecked = true;
        }
    }

       public void OpenBankApp(){
        if (WhichLevelNum == 1){
         SceneManager.LoadScene("Lv1BankApp");
           }
    }

    public void OpenBirdBookApp(){
        if (WhichLevelNum == 1){
        SceneManager.LoadScene("Lv1BirdBooks");}
    }

    public void OpenSettingApp(){
        if (WhichLevelNum == 1){
        SceneManager.LoadScene("SettingApp");}
    }

    public void OpenMemoApp(){
        if (WhichLevelNum == 1){
        SceneManager.LoadScene("Lv1MemoApp");}
    }

    public void OpenSNSApp(){
        if (WhichLevelNum == 1){
        SceneManager.LoadScene("Lv1SNS");}
        if (WhichLevelNum == 2){
        SceneManager.LoadScene("Lv2SNS");}
    }
    public void OpenBookBori(){
        if (WhichLevelNum == 1){
        SceneManager.LoadScene("Lv1BookBori");}
    }


}
 
     