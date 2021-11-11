using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BookCrossingIntro : MonoBehaviour
{

    public List<GameObject> obj;

    public GameObject StartPoint;
    public GameObject OriginalPoint;
    public GameObject OutPoint;
    public GameObject HandPoint;

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
        LeanTween.move(obj[0].GetComponent<RectTransform>(),  
        new Vector3(OriginalPoint.GetComponent<RectTransform>().anchoredPosition.x, 
        OriginalPoint.GetComponent<RectTransform>().anchoredPosition.y, 
        0), 2f).setEase(LeanTweenType.easeInOutBack);

    }

    public void AImgDown(){
        //LeanTween.alpha(obj[0].GetComponent<RectTransform>(), 0f, 3f).setDelay(0f);
             LeanTween.move(obj[0].GetComponent<RectTransform>(),  
        new Vector3(OutPoint.GetComponent<RectTransform>().anchoredPosition.x, 
        OutPoint.GetComponent<RectTransform>().anchoredPosition.y, 
        0), 2f).setEase(LeanTweenType.easeInOutBack);
    }

     public void BImg(){
        obj[1].SetActive(true);
        LeanTween.move(obj[1].GetComponent<RectTransform>(),  
        new Vector3(OriginalPoint.GetComponent<RectTransform>().anchoredPosition.x, 
        OriginalPoint.GetComponent<RectTransform>().anchoredPosition.y, 
        0), 2f).setEase(LeanTweenType.easeInOutBack);
     }

     public void BImgDown(){
        LeanTween.move(obj[1].GetComponent<RectTransform>(),
        new Vector3(OutPoint.GetComponent<RectTransform>().anchoredPosition.x, 
        OutPoint.GetComponent<RectTransform>().anchoredPosition.y, 
        0), 2f).setEase(LeanTweenType.easeInOutBack);
    }

    public void CImg(){
        obj[2].SetActive(true);
        obj[3].SetActive(true);
        obj[4].SetActive(true);
         LeanTween.move(obj[2].GetComponent<RectTransform>(),  
        new Vector3(HandPoint.GetComponent<RectTransform>().anchoredPosition.x, 
        HandPoint.GetComponent<RectTransform>().anchoredPosition.y, 
        0), 3f).setEase(LeanTweenType.easeInOutBack);
         LeanTween.move(obj[3].GetComponent<RectTransform>(),  
        new Vector3(OriginalPoint.GetComponent<RectTransform>().anchoredPosition.x, 
        OriginalPoint.GetComponent<RectTransform>().anchoredPosition.y, 
        0), 3f).setEase(LeanTweenType.easeInOutBack);

        LeanTween.move(obj[4].GetComponent<RectTransform>(), //book
        new Vector3(HandPoint.GetComponent<RectTransform>().anchoredPosition.x-200, 
        HandPoint.GetComponent<RectTransform>().anchoredPosition.y+10, 
        0), 3f).setEase(LeanTweenType.easeInOutBack);
     }
     public void CImgDown(){
        
        LeanTween.move(obj[2].GetComponent<RectTransform>(),
        new Vector3(HandPoint.GetComponent<RectTransform>().anchoredPosition.x+800, 
        HandPoint.GetComponent<RectTransform>().anchoredPosition.y+800, 
        0), 3f).setEase(LeanTweenType.easeInOutBack).setDelay(1f);
        


         LeanTween.move(obj[3].GetComponent<RectTransform>(), // bookdropper
        new Vector3(OutPoint.GetComponent<RectTransform>().anchoredPosition.x, 
        OutPoint.GetComponent<RectTransform>().anchoredPosition.y, 
        0), 3f).setEase(LeanTweenType.easeInOutBack).setDelay(1f);

        LeanTween.move(obj[4].GetComponent<RectTransform>(), //book
        new Vector3(OutPoint.GetComponent<RectTransform>().anchoredPosition.x, 
        OutPoint.GetComponent<RectTransform>().anchoredPosition.y, 
        0), 3f).setEase(LeanTweenType.easeInOutBack).setDelay(1f);
    }

        public void DImg(){
            
            obj[5].SetActive(true);
            obj[6].SetActive(true);
            LeanTween.move(obj[5].GetComponent<RectTransform>(),  
                new Vector3(OriginalPoint.GetComponent<RectTransform>().anchoredPosition.x, 
                OriginalPoint.GetComponent<RectTransform>().anchoredPosition.y, 
                0), 3f).setEase(LeanTweenType.easeInBack);

            LeanTween.move(obj[6].GetComponent<RectTransform>(),  
                new Vector3(HandPoint.GetComponent<RectTransform>().anchoredPosition.x, 
                HandPoint.GetComponent<RectTransform>().anchoredPosition.y, 
                0), 3f).setEase(LeanTweenType.easeInBack);

        }

        public void DImgDown(){

            LeanTween.move(obj[5].GetComponent<RectTransform>(), //
                new Vector3(OutPoint.GetComponent<RectTransform>().anchoredPosition.x, 
                OutPoint.GetComponent<RectTransform>().anchoredPosition.y, 
                0), 3f).setEase(LeanTweenType.easeInOutBack).setDelay(1f);

            LeanTween.move(obj[6].GetComponent<RectTransform>(), // 
                new Vector3(OutPoint.GetComponent<RectTransform>().anchoredPosition.x, 
                OutPoint.GetComponent<RectTransform>().anchoredPosition.y, 
                0), 3f).setEase(LeanTweenType.easeInOutBack).setDelay(1f);

        }

        
         


}
