using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSecondFeedScript : MonoBehaviour
{
    public GameObject firstText;
    void OnEnable(){
        LeanTween.moveY(gameObject, firstText.transform.position.y, 4f).setEase(LeanTweenType.easeInBack);//.setDelay(0.5f);
    }

}
