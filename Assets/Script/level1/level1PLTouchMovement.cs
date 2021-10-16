using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1PLTouchMovement : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private bool isLookBook = false;

   void Start(){
 

   }
   void Update(){
       MouseInput();

   }
   
    void MouseInput(){

        
            if(Input.GetMouseButton(0)){

                //카메라에 올라온 마우스 레이케스트
                Vector2 raycastPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D Hit = Physics2D.Raycast(raycastPosition, Vector2.zero);

                //if a collider is hit
                if (Hit.collider != null){

                    Debug.Log(Hit.collider.gameObject.name);
                }

                if (isLookBook == false) {
                    if (Hit.collider.gameObject.name == "OrangeBook") {

                        //LeanTween.scale(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().localScale*1.5f, 1f).setDelay(1f);
                        LeanTween.scaleX (gameObject, 0.02f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(0f);
                        LeanTween.scaleY (gameObject, 1.25f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(0f);
                        StartCoroutine(ChangeSprite());
                        LeanTween.scaleX (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(0.25f);
                        LeanTween.scaleY (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(0.25f);
                        LeanTween.moveY (this.gameObject, -0.16f, 0f).setDelay(0.25f);
                        //LeanTween.scale(gameObject.GetComponent<RectTransform>(), gameObject.GetComponent<RectTransform>().localScale*1f, 1f).setDelay(1f);
                        LeanTween.moveX (this.gameObject, 1f, 5.0f).setEase(LeanTweenType.easeInOutCubic).setDelay(0.25f);

                        
                        isLookBook = true;
                    }

                }

                 if (isLookBook == true) {
                    if (Hit.collider.gameObject.name == "door") {

                        LeanTween.moveX (this.gameObject, 4f, 5.0f).setEase(LeanTweenType.easeInOutCubic);

                   
                    }

                }
        }
    }

    IEnumerator ChangeSprite()
    {
        yield return new WaitForSeconds(0.25f);
        spriteRenderer.sprite = newSprite; 
    }

}
