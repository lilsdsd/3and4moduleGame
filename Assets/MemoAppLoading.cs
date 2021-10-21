using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoAppLoading : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(Timer());
         StartCoroutine(SelfKillTimer());
         
    }

    IEnumerator Timer(){
       // yield return new WaitForSeconds(2f);
        
            LeanTween.size(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().sizeDelta*0,1f ).setEase(LeanTweenType.easeInExpo);
            LeanTween.alphaText( transform.GetChild(0).GetComponent<RectTransform>(), 0f, 1f).setEase(LeanTweenType.easeInCirc);
        yield break;
    }

    IEnumerator SelfKillTimer(){
            yield return new WaitForSeconds(3f);
            Destroy(gameObject);
    }


    
}
