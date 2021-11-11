using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OpenningHand2 : MonoBehaviour, IDropHandler
{

    public GameObject OpenningSceneDialogue;
    public Image spriteRenderer;
    public Sprite newSprite;

    public GameObject Book;


     public void OnDrop(PointerEventData eventData){
         


           if (eventData.pointerDrag != null ){

                spriteRenderer.sprite = newSprite; 

                Debug.Log("OnBook2DropSucceseful");
                Book.SetActive(false);

                OpenningSceneDialogue.GetComponent<OpenningSceneDialogue>().eventNum += 1;
                OpenningSceneDialogue.GetComponent<OpenningSceneDialogue>().DialogueEvent();

               // LeanTween.scale(Book.GetComponent<RectTransform>(), Book.GetComponent<RectTransform>().localScale*0.5f, 0.8f);


           }


    }
}
