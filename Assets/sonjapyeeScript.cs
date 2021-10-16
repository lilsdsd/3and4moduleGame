using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonjapyeeScript : MonoBehaviour
{
    
    public float TheSpeedSecond = 1f;


    void Start(){
        StartCoroutine(TrunLeft());
    }



    IEnumerator TrunRight(){
        //TheZValue = degreesPerSecond * Time.deltaTime;
        //transform.Rotate(0, 0, TheZValue);
         LeanTween.rotate(gameObject, new Vector3(0f,0f,1f), TheSpeedSecond).setEase(LeanTweenType.easeInSine);
         yield return new WaitForSeconds(TheSpeedSecond);
          StartCoroutine(TrunLeft());
         
    }

    IEnumerator TrunLeft(){
         //transform.Rotate(0, 0, -degreesPerSecond * Time.deltaTime);
          //TheZValue = -degreesPerSecond * Time.deltaTime;
          //transform.Rotate(0, 0, TheZValue);
           LeanTween.rotate(gameObject, new Vector3(0f,0f,-2f), TheSpeedSecond).setEase(LeanTweenType.easeInSine);
            yield return new WaitForSeconds(TheSpeedSecond);
             StartCoroutine(TrunRight());

    }
}
