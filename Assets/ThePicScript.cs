using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThePicScript : MonoBehaviour
{

  //  public float PosX;
    //public float PosY;
    private bool canMove = true;
    public GameObject fadeoutObj;
    public GameObject PopupPicObj;
    // Start is called before the first frame update
   

   public void OnClick(){
        
       if( canMove == true ){
           LeanTween.move(gameObject.GetComponent<RectTransform>(), new Vector3(850f,250f,1000f), 1f).setEase(LeanTweenType.easeOutQuart);
            LeanTween.rotate(gameObject.GetComponent<RectTransform>(), -25f, 1f).setEase(LeanTweenType.easeOutQuart);
            LeanTween.move(gameObject.GetComponent<RectTransform>(), new Vector3(250f,0f,1000f), 2f).setEase(LeanTweenType.easeOutQuart).setDelay(1f);
            LeanTween.rotate(gameObject.GetComponent<RectTransform>(), 5f, 1f).setEase(LeanTweenType.easeOutQuart).setDelay(1f);
            transform.SetSiblingIndex(3);
            StartCoroutine(PopupPic());
            
            //LeanTween.alpha(gameObject, 0f, 2f);
           canMove = false;
       }
   }

    public IEnumerator PopupPic(){
        yield return new WaitForSeconds(3f);
        PopupPicObj.SetActive(true);
        StartCoroutine(FadeOutBG());
        transform.SetSiblingIndex(0);
        yield return new WaitForSeconds(2f);
        
        Destroy(gameObject);
        
        
        
        yield break;

    }

    IEnumerator FadeOutBG(){
        fadeoutObj.SetActive(true);
        
        yield break;
    }


}
