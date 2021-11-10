using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BookCrossingIntro : MonoBehaviour
{

    void Awake(){
       LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 0f, 3f).setDelay(0f);
      // gameObject.setActive(false);
    }
    // Start is called before the first frame update
    void OnEnable()
    {
        LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 1f, 3f).setDelay(1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
