using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookBoriLauncherScrpt : MonoBehaviour
{

    public GameObject BookBoriLoading;
    void Awake(){
        LeanTween.scale( BookBoriLoading.GetComponent<RectTransform>(), BookBoriLoading.GetComponent<RectTransform>().localScale*0.001f, 0f).setDelay(0f);
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void OnEnable()
    {
        LeanTween.scale( BookBoriLoading.GetComponent<RectTransform>(), BookBoriLoading.GetComponent<RectTransform>().localScale*1f, 1f).setEase(LeanTweenType.easeInOutExpo).setDelay(0.5f);
    }

}
