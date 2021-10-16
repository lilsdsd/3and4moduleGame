using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenAnimation : MonoBehaviour
{

    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void PressMoveButton(){

        LeanTween.move(door, new Vector3(0f, -1f, 0f), 2.0f).setEase(LeanTweenType.easeOutElastic);
    } 

    public void ClickRotate(){

        LeanTween.rotateAround(door, Vector3.forward, 360f, 3f ).setLoopClamp();
    } 

    public void ClickScale(){
        LeanTween.scale(door, new Vector3(3,3,3), 2f).setEase(LeanTweenType.easeOutElastic);
    }

    public void ClickColor() {
        LeanTween.color( door, new Color(0.365f, 0.55f, 1.0f, 1.0f), 1f).setDelay(1f);
    }

    public void ClickAlpha() {
        LeanTween.alpha(door, 0f, 1f);
    
    }

    public void CustomizeParameter(){
        int id = LeanTween.moveX(door, 1f, 1f).id;
        LTDescr d = LeanTween.descr(id);

        if(d != null) {// if the Tween has already finished it will return null

            d.setOnComplete( onCompleteFunc ).setEase(LeanTweenType.easeInOutBack);

        }
    }

    void onCompleteFunc() {
        LeanTween.scale( door, new Vector3(3,3,3), 2f).setEase(LeanTweenType.easeOutElastic);
    }

}
