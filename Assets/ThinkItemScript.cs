using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThinkItemScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData){
        

    }
    public void OnBeginDrag(PointerEventData eventData){
        
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.6f;
    }
    public void OnDrag(PointerEventData eventData){

        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; 

    }
    public void OnEndDrag(PointerEventData eventData){
        
    canvasGroup.blocksRaycasts = true;
    canvasGroup.alpha = 1f;
    }

    
    
}
