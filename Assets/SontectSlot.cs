using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SontectSlot : MonoBehaviour, IDropHandler
{
  public GameObject MyMessageBox; 
  public GameObject Originsize;
  public GameObject MessageA;
  public GameObject MessageB;

  public void OnDrop(PointerEventData eventData){
      
      Debug.Log("OnDrop");
    if (eventData.pointerDrag != null && eventData.pointerDrag == MessageA){
        Debug.Log("MessageAOnDropSucceseful");
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        LeanTween.size(MyMessageBox.GetComponent<RectTransform>(), Originsize.GetComponent<RectTransform>().sizeDelta*1f, 1f).setEase(LeanTweenType.easeInExpo);
    }




  }
}
