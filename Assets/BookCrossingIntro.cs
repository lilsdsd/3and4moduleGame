using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BookCrossingIntro : MonoBehaviour
{

    public List<GameObject> obj;

    void Awake(){
       LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 0f, 3f).setDelay(0f);
        for(int i = 0; i < obj.Count; i++){
            LeanTween.alpha(obj[i].GetComponent<RectTransform>(), 0f, 3f).setDelay(0f);
            obj[i].SetActive(false);
        }
      // gameObject.setActive(false);
    }
    // Start is called before the first frame update
    void OnEnable()
    {
        LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 1f, 3f).setDelay(1f);
    }

    public void AImg(){

        obj[0].SetActive(true);

    }

    public void AImgDown(){
        LeanTween.alpha(obj[0].GetComponent<RectTransform>(), 0f, 3f).setDelay(0f);
    }

     public void BImg(){
        obj[1].SetActive(true);
     }

     public void BImgDown(){
        LeanTween.alpha(obj[1].GetComponent<RectTransform>(), 0f, 3f).setDelay(0f);
    }

    public void CImg(){
        obj[2].SetActive(true);
     }
     public void CImgDown(){
        LeanTween.alpha(obj[2].GetComponent<RectTransform>(), 0f, 3f).setDelay(0f);
    }




}
