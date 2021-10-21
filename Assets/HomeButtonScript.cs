using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonScript : MonoBehaviour
{
    public void HomeButtonPressed(){
        SceneManager.LoadScene("Lv1MainScreen");
    } 
}
