using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jangbaguni : MonoBehaviour, IDropHandler
{
    public CanvasGroup background;
    public GameObject chatGroup;
    public GameObject PopUpGroup;
    
    

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDorp");
        if(eventData.pointerDrag != null){
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent <RectTransform>().anchoredPosition;
            LeanTween.scale(this.gameObject, new Vector3( 1.2f, 1.2f, 1.2f), 0.25f).setEaseInOutBack();
            eventData.pointerDrag.SetActive(false);
            LeanTween.move(this.gameObject, new Vector3(-Screen.width+500f, this.transform.position.y,0f), 2.5f).setEaseInBack().setDelay(0.5f);
            LeanTween.move(chatGroup, new Vector3(Screen.width-150f, chatGroup.transform.position.y,0f), 2.5f).setEaseInBack().setDelay(0.5f);
            background.LeanAlpha(0, 2.5f);
            StartCoroutine(DisablePopupGroup());
               
            
            //eventData.LeanTween.scale(eventData.gameObject, new Vector3( 0.2f, 0.2f, 0.2f), 0.5f);
        }
    }

    public void OnPointerDown(PointerEventData eventData) 
       {
           
       }


    IEnumerator DisablePopupGroup(){
        yield return new WaitForSeconds(2.5f);
        PopUpGroup.SetActive(false);
        yield break;
    }
}
