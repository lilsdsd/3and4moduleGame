using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lv1RingScreenDeclineButton : MonoBehaviour
{
   public GameObject text;

    // Update is called once per frame
    public void ButtonPressed(){
        LeanTween.size(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().sizeDelta*0f, 3f).setEase(LeanTweenType.easeInOutCubic);
        text.SetActive(true);
    }
}
