using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    
    public GameObject firstText;

    public GameObject firstFeed;

    public GameObject FeedImage;
    public GameObject ThirdFeedButtonA;
    public GameObject ThirdFeedButtonB;

    public GameObject ThirdFeedButtonC;

    int eventnumber = 0;

    void Awake()
    {
         Screen.orientation = ScreenOrientation.Portrait;
         LeanTween.size(ThirdFeedButtonC.GetComponent<RectTransform>(), ThirdFeedButtonA.GetComponent<RectTransform>().sizeDelta*0.001f, 0f).setEase(LeanTweenType.easeInOutExpo).setDelay(0f);
         LeanTween.alpha(ThirdFeedButtonC, 0f, 0f) .setDelay(0f);
    }

    void Start(){
        LeanTween.moveY(firstText, firstText.transform.position.y + 450f, 3f).setEase(LeanTweenType.easeInBack).setDelay(2f);
        LeanTween.moveY(firstFeed, firstText.transform.position.y, 4f).setEase(LeanTweenType.easeInOutBack).setDelay(3f);
    }

    public void OnClick(){
        LeanTween.moveY(firstFeed, firstText.transform.position.y+185f, 4f).setEase(LeanTweenType.easeOutExpo);//.setDelay(3f);
    }


    public void OnClick2(){
        LeanTween.moveY(firstFeed, firstText.transform.position.y+815f, 4f).setEase(LeanTweenType.easeOutExpo);//.setDelay(3f);
    }

     public void OnClick3(){
        LeanTween.moveX(FeedImage, FeedImage.transform.position.x-315f, 2f).setEase(LeanTweenType.easeOutExpo);//.setDelay(3f);
        eventnumber += 1;
        if(eventnumber ==2) {
            LeanTween.size(ThirdFeedButtonA.GetComponent<RectTransform>(), ThirdFeedButtonA.GetComponent<RectTransform>().sizeDelta*0f, 1f).setEase(LeanTweenType.easeInOutExpo).setDelay(1f);
            LeanTween.size(ThirdFeedButtonB.GetComponent<RectTransform>(), ThirdFeedButtonB.GetComponent<RectTransform>().sizeDelta*0f, 1f).setEase(LeanTweenType.easeInOutExpo).setDelay(1f);
            LeanTween.alpha(ThirdFeedButtonC, 1f, 0f) .setDelay(0f);
            LeanTween.size(ThirdFeedButtonC.GetComponent<RectTransform>(), ThirdFeedButtonC.GetComponent<RectTransform>().sizeDelta*1000f, 1f).setEase(LeanTweenType.easeInOutExpo).setDelay(1f);
        }
    }
    public void OnClick4(){
        LeanTween.moveX(FeedImage, FeedImage.transform.position.x+315f, 1.5f).setEase(LeanTweenType.easeOutExpo);//.setDelay(3f);
        eventnumber -= 1;
    }


}
