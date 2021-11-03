using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordScreenSystem : MonoBehaviour
{
    
    public List<GameObject> LockedScreenObjects;
    public GameObject TriggerButton;
    public void ScreenTouched(){
        Debug.Log("ScreenTouched");
        for(int i = 0 ; i < LockedScreenObjects.Count; i++ ){
            LeanTween.alpha(LockedScreenObjects[i].GetComponent<RectTransform>(), 0f, 1f);
            StartCoroutine(DisableObject(i));
        }
        //TriggerButton.SetActive(false);
    }

    
    public void GoBack(){
       Debug.Log("Goback");
        for(int i = 0 ; i < LockedScreenObjects.Count; i++ ){
            StartCoroutine(EableObject(i));
            LeanTween.alpha(LockedScreenObjects[i].GetComponent<RectTransform>(), 1f, 1f);
        }
       //TriggerButton.SetActive(true);
    }
    IEnumerator DisableObject(int i){
        yield return new WaitForSeconds(1f);
        LockedScreenObjects[i].SetActive(false);
        
        yield break;
    }
    IEnumerator EableObject(int i){
        LockedScreenObjects[i].SetActive(true);
        
        yield break;
    }
}
