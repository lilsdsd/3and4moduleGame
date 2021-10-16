using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubwayCameraScript : MonoBehaviour
{
    
    public float MovingRange = 5f;


    void Start(){
       // StartCoroutine(TrunUp());
        StartCoroutine(TrunLeft());
    }



    IEnumerator TrunUp(){
        //TheZValue = degreesPerSecond * Time.deltaTime;
        //transform.Rotate(0, 0, TheZValue);
         LeanTween.rotate(gameObject, new Vector3(0f,2f,0f), 3f).setEase(LeanTweenType.easeInSine);
         yield return new WaitForSeconds(3f);
          StartCoroutine(TrunDown());
         
    }

    IEnumerator TrunDown(){
         //transform.Rotate(0, 0, -degreesPerSecond * Time.deltaTime);
          //TheZValue = -degreesPerSecond * Time.deltaTime;
          //transform.Rotate(0, 0, TheZValue);
           LeanTween.rotate(gameObject, new Vector3(0f,-2f,0f), 3f).setEase(LeanTweenType.easeInSine);
            yield return new WaitForSeconds(3f);
             StartCoroutine(TrunUp());

    }

       IEnumerator TrunRight(){
        //TheZValue = degreesPerSecond * Time.deltaTime;
        //transform.Rotate(0, 0, TheZValue);
         LeanTween.move(gameObject, new Vector3(MovingRange,0f,0f), 2f).setEase(LeanTweenType.easeInSine);
         yield return new WaitForSeconds(2f);
          StartCoroutine(TrunLeft());
         
    }

    IEnumerator TrunLeft(){
         //transform.Rotate(0, 0, -degreesPerSecond * Time.deltaTime);
          //TheZValue = -degreesPerSecond * Time.deltaTime;
          //transform.Rotate(0, 0, TheZValue);
           LeanTween.move(gameObject, new Vector3(-MovingRange,0f,0f), 2f).setEase(LeanTweenType.easeInSine);
            yield return new WaitForSeconds(2f);
             StartCoroutine(TrunRight());

    }
}
