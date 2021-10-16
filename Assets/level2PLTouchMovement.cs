using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2PLTouchMovement : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite walkingSprite;
    public Sprite nolamSprtie;
    public Sprite phoneLoookingSprite;
    public float walkingTime = 1.5f;
    public GameObject PopupAlarmA;
    public GameObject PopupAlarmB;
    public GameObject PopupAlarmC;
    //private bool isLookBook = false;
    public int walkingProsses = 0; // 시퀸스 넘버 (알람)
    bool isWalk = false;
    bool keepGoing = false;

   void Update(){
      // MouseInput();
       if (isWalk == true) {
                        // 걸어가고있는 상태
                        //LeanTween.moveX (this.gameObject, 2f, walkingTime).setDelay(0f);
                        //ㅇㅝㄴ래는 4f 
                       // LeanTween.move(this.gameObject, new Vector3( gameObject.transform.position.x + 4f,gameObject.transform.position.y,gameObject.transform.position.z), walkingTime).setDelay(0f);
                        
                        LeanTween.moveX(gameObject, gameObject.transform.position.x  + 4f, walkingTime);
                        StartCoroutine(ChangeSpriteToWalk());
                        if (keepGoing == false){
                            isWalk = false; 
                        }
                        
                }
   }
   
   // void MouseInput(){
    public void bubbleClicked() {

        
           // if(Input.GetMouseButtonDown(0)){

                //카메라에 올라온 마우스 레이케스트
                Vector2 raycastPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D Hit = Physics2D.Raycast(raycastPosition, Vector2.zero);

                //if a collider is hit
                if (Hit.collider != null){

                    Debug.Log(Hit.collider.gameObject.name);
                }

                if(walkingProsses == 3){
                    keepGoing = true;
                    isWalk = true;
                }

                if ( walkingProsses == 2) {
                        isWalk = true;
                        //walkingProsses = 1;

                        //LeanTween.move (gameObject, new Vector3(0f,-3f,5f), 2.0f).setEase()
                        //알람이와서 놀람
                        LeanTween.scaleX (gameObject, 0.02f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2f);// 줄이기
                        LeanTween.scaleY (gameObject, 1.25f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2f);//늘리기
                        //StartCoroutine(ChangeSpriteToNolam());
                        LeanTween.scaleX (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2.25f);//원상태 복귀
                        LeanTween.scaleY (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2.25f);//원상태 복귀
                        
                       //폰보기
                        LeanTween.scaleX (gameObject, 0.02f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3f);// 줄이기
                        LeanTween.scaleY (gameObject, 1.25f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3f);//늘리기
                        StartCoroutine(ChangeSpriteToPhone());
                        
                        LeanTween.scaleX (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3.25f);//원상태 복귀
                        LeanTween.scaleY (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3.25f);//원상태 복귀

                       //알람 이벤트 엑티브
                       StartCoroutine(OpenUpPopupC());
                        
                        

                }

               if ( walkingProsses == 1) {
                        isWalk = true;
                        //walkingProsses = 1;
                        //알람이와서 놀람
                       // LeanTween.scaleX (gameObject, 0.02f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2f);// 줄이기
                       // LeanTween.scaleY (gameObject, 1.25f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2f);//늘리기
                        //StartCoroutine(ChangeSpriteToNolam());
                      //  LeanTween.scaleX (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2.25f);//원상태 복귀
                       // LeanTween.scaleY (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2.25f);//원상태 복귀
                        
                       //폰보기
                        LeanTween.scaleX (gameObject, 0.02f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3f);// 줄이기
                        LeanTween.scaleY (gameObject, 1.25f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3f);//늘리기
                        StartCoroutine(ChangeSpriteToPhone());
                        StartCoroutine(StopFloating());
                        LeanTween.scaleX (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3.25f);//원상태 복귀
                        LeanTween.scaleY (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3.25f);//원상태 복귀

                       //알람 이벤트 엑티브
                       StartCoroutine(OpenUpPopupB());
                       Debug.Log("BActivated");
                        
                        

                }
                if ( walkingProsses == 0) {
                        isWalk = true;
                        
                        //알람이와서 놀람
                        //LeanTween.scaleX (gameObject, 0.02f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2f);// 줄이기
                       // LeanTween.scaleY (gameObject, 1.25f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2f);//늘리기
                       // StartCoroutine(ChangeSpriteToNolam());
                       // LeanTween.scaleX (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2.25f);//원상태 복귀
                       // LeanTween.scaleY (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(2.25f);//원상태 복귀
                        
                       //폰보기
                        LeanTween.scaleX (gameObject, 0.02f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3f);// 줄이기
                        LeanTween.scaleY (gameObject, 1.25f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3f);//늘리기
                        StartCoroutine(ChangeSpriteToPhone());
                        StartCoroutine(StopFloating());
                        LeanTween.scaleX (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3.25f);//원상태 복귀
                        LeanTween.scaleY (gameObject, 1f, 0.25f).setEase(LeanTweenType.easeInOutCubic).setDelay(3.25f);//원상태 복귀

                       //알람 이벤트 엑티브
                       StartCoroutine(OpenUpPopupA());
                        
                        

                }

                walkingProsses += 1;
                Debug.Log("WalkingProsses: " + walkingProsses);
        //}
    }

    public IEnumerator ChangeSpriteToNolam()
    {
        yield return new WaitForSeconds(2f);
        spriteRenderer.sprite = nolamSprtie; 
    }
    IEnumerator ChangeSpriteToPhone()
    {
        yield return new WaitForSeconds(3f);
        spriteRenderer.sprite = phoneLoookingSprite; 
    }

    IEnumerator ChangeSpriteToWalk()
    {
        
        spriteRenderer.sprite = walkingSprite; 
        yield return new WaitForSeconds(walkingTime);//걸어가는 시간
        
    }

    IEnumerator OpenUpPopupA()
    {
        yield return new WaitForSeconds(4f);
        PopupAlarmA.SetActive(true);
    }

      IEnumerator OpenUpPopupB()
    {
        yield return new WaitForSeconds(4f);
        PopupAlarmB.SetActive(true);
    }
      IEnumerator OpenUpPopupC()
    {
        yield return new WaitForSeconds(4f);
        PopupAlarmC.SetActive(true);
    }

    IEnumerator StopFloating()
    {
        yield return new WaitForSeconds(walkingTime);
        gameObject.GetComponent<Floating>().isTimerOn = false;
        gameObject.GetComponent<Floating>().isWalking = false;
    }
  
}
