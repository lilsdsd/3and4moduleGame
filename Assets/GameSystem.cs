using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenMessageApp(){
        SceneManager.LoadScene("Lv1Message");
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


}
