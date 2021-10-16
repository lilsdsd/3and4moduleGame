using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroFirstFeedScript : MonoBehaviour
{
    public void OnClick(){
        LeanTween.moveY(gameObject, gameObject.transform.position.y+300f, 4f).setEase(LeanTweenType.easeInOutBack);//.setDelay(3f);
    }
}
