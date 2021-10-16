using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1RingingScreenScript : MonoBehaviour
{
    // Start is called before the first frame update

    void Awake(){
       
        LeanTween.size(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().sizeDelta*0f, 0f).setDelay(0f);
    }
    void OnEnable()
    {
        Debug.Log("RingingScreenObject Active Succeseful.");
        LeanTween.size(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().sizeDelta, 3f).setDelay(1f).setEase(LeanTweenType.easeInBack);
    }

    
}
