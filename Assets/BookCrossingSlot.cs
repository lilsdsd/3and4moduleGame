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
  public GameObject OutsidePointDown;
  public GameObject OutsidePointUp;
  GameObject ClickedObject;

    bool isGoOut = false;

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
            BigBook.GetComponent<RectTransform>().anchoredPosition= new Vector3(BigBook.GetComponent<RectTransform>().anchoredPosition.x, BigBook.GetComponent<RectTransform>().anchoredPosition.y-25);
            ClickedObject.GetComponent<RectTransform>().anchoredPosition= new Vector3(ClickedObject.GetComponent<RectTransform>().anchoredPosition.x, ClickedObject.GetComponent<RectTransform>().anchoredPosition.y+25);
        }
  }
    IEnumerator GoOutSide(){

        yield return new WaitForSeconds(3);
        isGoOut = true;
        Debug.Log("GooutTigger On");
        yield break;
    }


}
