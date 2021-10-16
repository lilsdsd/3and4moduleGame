using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadFeedScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    public void OnClick()
    {
        LeanTween.moveX(gameObject, gameObject.transform.position.x-315f, 2.5f).setEase(LeanTweenType.easeOutExpo);//.setDelay(3f);
    }
}
