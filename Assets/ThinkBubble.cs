using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThinkBubble : MonoBehaviour, IDropHandler
{
    public GameObject Item;

    public void OnDrop(PointerEventData eventData) {
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //맨뒤에 /2 수치를 조절하여 아이템 배치 구역을 조절하기, /2를 없에면 중앙으로 간다.
            if (eventData.pointerDrag == Item){
                Item.GetComponent<CanvasGroup>().blocksRaycasts = false;
                Item.GetComponent<CanvasGroup>().interactable = false;
                LeanTween.size(gameObject.GetComponent<RectTransform>(),gameObject.GetComponent<RectTransform>().sizeDelta*1.1f, 0.25f);
                LeanTween.size(Item.GetComponent<RectTransform>(), Item.GetComponent<RectTransform>().sizeDelta*1.1f, 0.25f);
                LeanTween.size(gameObject.GetComponent<RectTransform>(),gameObject.GetComponent<RectTransform>().sizeDelta*0f, 0.5f).setDelay(0.25f);
                LeanTween.size(Item.GetComponent<RectTransform>(), Item.GetComponent<RectTransform>().sizeDelta*0f, 0.5f).setDelay(0.25f);
            }
            
        }
    }
}
