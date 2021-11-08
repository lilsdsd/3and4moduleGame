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
  public GameObject MovementPoint;

    

  public void OnDrop(PointerEventData eventData){
      
      Debug.Log("OnDrop");
    if (eventData.pointerDrag != null ){
        Debug.Log("BookOnDropSucceseful");
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        LeanTween.size(eventData.pointerDrag.GetComponent<RectTransform>(), BigBook.GetComponent<RectTransform>().sizeDelta*1f, 0.5f).setEase(LeanTweenType.easeInOutExpo);
        eventData.pointerDrag.GetComponent<CanvasGroup>().alpha = 1f;
        eventData.pointerDrag.GetComponent<BookCrossingDragDrop>().enabled = false;
        Debug.Log("BookDragAndDropScriptDisabled");

        LeanTween.size(BigBook.GetComponent<RectTransform>(), BigBook.GetComponent<RectTransform>().sizeDelta*0.5f, 0.5f).setEase(LeanTweenType.easeInOutExpo);
        LeanTween.move(BigBook, MovementPoint.GetComponent<RectTransform>().position, 2.5f).setEase(LeanTweenType.easeInOutExpo);

       // LeanTween.move(eventData.pointerDrag, eventData.pointerDrag.GetComponent<RectTransform>().position.x *2, 2.5f).setEase(LeanTweenType.easeInOutExpo).setDelay(3f);
       // LeanTween.move(BigBook, BigBook.GetComponent<RectTransform>().position.x * -2, 2.5f).setEase(LeanTweenType.easeInOutExpo).setDelay(3f);
    }




  }
}
