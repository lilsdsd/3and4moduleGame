using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BookCrossingSlot : MonoBehaviour, IDropHandler
{
  //public GameObject MyMessageBox; 
  //public GameObject Originsize;
  public GameObject BigBook;
  public GameObject TradeMovementPoint;
  public GameObject BookCrossingGroup;
  public GameObject ReactionGroup;
  public GameObject MobileScreen;

  public GameObject TheHealthBar;
  
  GameObject ClickedObject;
  

    bool isGoOut = false;

    void Awake(){
        ReactionGroup.GetComponent<RectTransform>().anchoredPosition =new Vector3(1920, 0f);
        ReactionGroup.SetActive(false);
    }
  public void OnDrop(PointerEventData eventData){
      
      Debug.Log("OnDrop");
    if (eventData.pointerDrag != null ){
             ClickedObject = eventData.pointerDrag;

        Debug.Log("BookOnDropSucceseful");
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        LeanTween.size(eventData.pointerDrag.GetComponent<RectTransform>(), BigBook.GetComponent<RectTransform>().sizeDelta*1f, 0.5f).setEase(LeanTweenType.easeInOutExpo);
        eventData.pointerDrag.GetComponent<CanvasGroup>().alpha = 1f;
        eventData.pointerDrag.GetComponent<BookCrossingDragDrop>().enabled = false;
        Debug.Log("BookDragAndDropScriptDisabled");

        LeanTween.size(BigBook.GetComponent<RectTransform>(), BigBook.GetComponent<RectTransform>().sizeDelta*0.5f, 0.5f).setEase(LeanTweenType.easeInOutExpo);
        LeanTween.move(BigBook, TradeMovementPoint.GetComponent<RectTransform>().position, 0.5f).setEase(LeanTweenType.easeInOutExpo);

    // LeanTween.moveY(eventData.pointerDrag.GetComponent<RectTransform>(), OutsidePointUp.GetComponent<RectTransform>().position.y*-5, 2.5f).setEase(LeanTweenType.easeInOutExpo).setDelay(2.8f);
   // LeanTween.moveY(BigBook.GetComponent<RectTransform>(), OutsidePointDown.GetComponent<RectTransform>().position.y * 5, 2.5f).setEase(LeanTweenType.easeInOutExpo).setDelay(2.8f);

        StartCoroutine(GoOutSide());
        
    }

  }
  void Update(){
      if (isGoOut == true){
            Debug.Log("Goouting");
           // BigBook.GetComponent<RectTransform>().anchoredPosition= new Vector3(BigBook.GetComponent<RectTransform>().anchoredPosition.x-25, BigBook.GetComponent<RectTransform>().anchoredPosition.y);
            //ClickedObject.GetComponent<RectTransform>().anchoredPosition= new Vector3(ClickedObject.GetComponent<RectTransform>().anchoredPosition.x-25, ClickedObject.GetComponent<RectTransform>().anchoredPosition.y);
            
            
            //ReactionGroup.GetComponent<RectTransform>().anchoredPosition= new Vector3(ReactionGroup.GetComponent<RectTransform>().anchoredPosition.x-25, ReactionGroup.GetComponent<RectTransform>().anchoredPosition.y);
           
        }
  }
    IEnumerator GoOutSide(){
      //  LeanTween.moveX(Camera, Camera.GetComponent<RectTransform>().anchoredPosition.x-19, 3f).setEase(LeanTweenType.easeInOutExpo).setDelay(2f);
      //LeanTween.value(Camera.gameObject, Camera.GetComponent<Transform>().transform.position, Camera.GetComponent<Transform>().transform.position, 3f).setOnUpdate((float flt) =>   {
        //Camera.GetComponent<Transform>().transform.position.x = flt;
          //  });
       // LeanTween.moveX(ReactionGroup, 0, 3f).setEase(LeanTweenType.easeInOutExpo).setDelay(2f);
        ReactionGroup.SetActive(true);
        LeanTween.move(ReactionGroup,MobileScreen.GetComponent<RectTransform>().localPosition , 3f).setEase(LeanTweenType.easeInOutSine);
        TheHealthBar.GetComponent<ReactionHealth>().Play();
        yield return new WaitForSeconds(3);
        isGoOut = true;
        Debug.Log("GooutTigger On");
        
        yield break;
    }


}
