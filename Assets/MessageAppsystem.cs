using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MessageAppsystem : MonoBehaviour
{

    public List<string> SceneName;


    public void OpenFirst(){
        SceneManager.LoadScene(SceneName[0]);
    }
    public void OpenSecond(){
        SceneManager.LoadScene(SceneName[1]);
    }
    public void OpenThird(){
        SceneManager.LoadScene(SceneName[2]);
    }


}
