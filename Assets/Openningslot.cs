using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Openningslot : MonoBehaviour, IDropHandler
{

    public GameObject OpenningSceneDialogue;
    public GameObject Book;

    public void OnDrop(PointerEventData eventData){
      
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null){
            Debug.Log("OnDropSucceseful");
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            OpenningSceneDialogue.GetComponent<OpenningSceneDialogue>().eventNum += 1;
            OpenningSceneDialogue.GetComponent<OpenningSceneDialogue>().DialogueEvent();
            Book.GetComponent<CanvasGroup>().interactable = false;
            Book.GetComponent<BookCrossingDragDrop>().enabled = false;
            
            LeanTween.move(Book.GetComponent<RectTransform>(), 
            new Vector3(gameObject.GetComponent<RectTransform>().anchoredPosition.x,
            gameObject.GetComponent<RectTransform>().anchoredPosition.y,
            0), 0.8f).setEase(LeanTweenType.easeInOutBack);

            LeanTween.scale(Book.GetComponent<RectTransform>(), Book.GetComponent<RectTransform>().localScale*0.5f, 0.8f);
    }




  }
}
