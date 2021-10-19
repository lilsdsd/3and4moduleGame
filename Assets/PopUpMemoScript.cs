using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMemoScript : MonoBehaviour
{
    public GameObject PopUpMemoGroupObject;
    void Awake(){   
        LeanTween.size(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().sizeDelta*0, 0f );
        gameObject.SetActive(false);

    }
    void OnEnable()
    {
       LeanTween.size(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().sizeDelta*0, 0f );

        LeanTween.size(gameObject.GetComponent<RectTransform>(), PopUpMemoGroupObject.GetComponent<RectTransform>().sizeDelta, 1f).setEase(LeanTweenType.easeInOutBack);
    }

}
