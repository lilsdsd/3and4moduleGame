using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookBoriSceneManager : MonoBehaviour
{
    public string SceneNameToGo;
      
    public void MoveToScene(){
        SceneManager.LoadScene(SceneNameToGo);
    }
    
}
