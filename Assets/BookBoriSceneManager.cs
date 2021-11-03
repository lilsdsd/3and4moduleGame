using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookBoriSceneManager : MonoBehaviour
{
      
    public void MoveToFirstBook(){
        SceneManager.LoadScene("Lv1FirstBook");
    }
}
