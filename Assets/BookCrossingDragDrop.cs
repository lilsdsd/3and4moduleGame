using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BookCrossingDragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    

    public void OnPointerDown(PointerEventData eventData)
    {
       Debug.Log("OnPointDown");
    }
    
    private void Awake(){
      rectTransform = GetComponent<RectTransform>();
      canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnDrag(PointerEventData eventData)
    {
       Debug.Log("OnDrag");
       rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

   public void OnEndDrag(PointerEventData eventData)
    {
       Debug.Log("OnEndDrag");
         canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

   public void OnBeginDrag(PointerEventData eventData)
    {
       Debug.Log("OnBeginDrag");
       canvasGroup.alpha = 0.6f;
       canvasGroup.blocksRaycasts = false;
    }

    public void OnDrop(PointerEventData eventData) {
      throw new System.NotImplementedException();
   }
}
